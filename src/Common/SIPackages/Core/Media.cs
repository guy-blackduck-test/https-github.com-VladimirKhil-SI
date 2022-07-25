﻿using System;

namespace SIPackages.Core
{
    /// <inheritdoc cref="IMedia" />
    public sealed class Media : IMedia
    {
        /// <inheritdoc />
        public Func<StreamInfo>? GetStream { get; }

        /// <inheritdoc />
        public string Uri { get; }

        private readonly Lazy<long>? _getStreamLength;

        /// <inheritdoc />
        public long StreamLength { get; private set; }

        /// <summary>
        /// Initializes a new instance of <see cref="Media" /> class.
        /// </summary>
        /// <param name="getStream">Stream factory.</param>
        /// <param name="getStreamLength">Stream length factory.</param>
        /// <param name="uri">Media uri.</param>
        public Media(Func<StreamInfo> getStream, Func<long> getStreamLength, string uri)
        {
            GetStream = getStream;
            Uri = uri;

            _getStreamLength = new Lazy<long>(getStreamLength);
            StreamLength = _getStreamLength.Value;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Media" /> class.
        /// </summary>
        /// <param name="uri">Media uri.</param>
        public Media(string uri)
        {
            Uri = uri;
            StreamLength = -1;
        }
    }
}
