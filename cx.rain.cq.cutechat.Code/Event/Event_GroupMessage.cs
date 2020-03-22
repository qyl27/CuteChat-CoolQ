using Native.Sdk.Cqp.EventArgs;
using Native.Sdk.Cqp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cx.rain.cq.cutechat.Code.Event
{
    public class Event_GroupMessage : IGroupMessage
    {
        public void GroupMessage(object sender, CQGroupMessageEventArgs e)
        {
            if (e.FromGroup.Id == CuteChat.GroupId)
            {
                SocketWorker.Send($"{e.CQApi.GetGroupMemberInfo(CuteChat.GroupId, e.FromQQ.Id).Nick}：{e.Message.ToSendString()}");
            }
        }
    }
}
