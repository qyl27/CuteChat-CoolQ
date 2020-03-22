using Native.Sdk.Cqp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace cx.rain.cq.cutechat.Code
{
    public class CuteChat
    {
        public static Socket Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static readonly List<Socket> Sockets = new List<Socket>();

        public static readonly long GroupId = 175498231;
        public static readonly int Port = 35423;

        public static CQApi Api = null;
        public static CQLog Log = null;
    }
}
