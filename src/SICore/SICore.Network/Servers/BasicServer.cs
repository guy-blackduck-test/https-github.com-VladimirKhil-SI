﻿
using SICore.Network.Configuration;
using SICore.Network.Contracts;

namespace SICore.Network.Servers
{
    /// <summary>
    /// Обычный (не сетевой) сервер
    /// </summary>
    public sealed class BasicServer : MasterNode
    {
        public BasicServer(NodeConfiguration serverConfiguration, INetworkLocalizer localizer)
            : base(serverConfiguration, localizer)
        {

        }
    }
}
