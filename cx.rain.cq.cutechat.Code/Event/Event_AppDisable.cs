using Native.Sdk.Cqp.EventArgs;
using Native.Sdk.Cqp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cx.rain.cq.cutechat.Code.Event
{
    public class Event_AppDisable : IAppDisable
    {
        public void AppDisable(object sender, CQAppDisableEventArgs e)
        {
            e.CQLog.Info("信息", "感谢使用！");

            CuteChat.Sockets.Clear();
            CuteChat.Socket.Close();
        }
    }
}
