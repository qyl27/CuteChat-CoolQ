using Native.Sdk.Cqp.EventArgs;
using Native.Sdk.Cqp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cx.rain.cq.cutechat.Code.Event
{
    public class Event_AppEnable : IAppEnable
    {
        public void AppEnable(object sender, CQAppEnableEventArgs e)
        {
            e.CQLog.Info("信息", "欢迎使用！");

            CuteChat.Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            CuteChat.Socket.Bind(new IPEndPoint(IPAddress.Any, CuteChat.Port));
            CuteChat.Socket.Listen(233);

            CuteChat.Socket.BeginAccept(SocketWorker.OnReceive, CuteChat.Socket);

            CuteChat.Api = e.CQApi;
        }
    }
}
