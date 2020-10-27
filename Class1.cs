using System;
using System.ComponentModel;
using Zappy.SharedInterface;
using Zappy.SharedInterface.Helper;

namespace CustomActivities
{
    public class NewCustumAction : TemplateAction
    {
        [Category("Input")]
        [Description("InputBox Text")]
        public DynamicProperty<string> Text { get; set; }

        public override void Invoke(IZappyExecutionContext context, ZappyTaskActionInvoker actionInvoker)
        {
          //     MessageBox.Show(Text);
        }


        public override string AuditInfo()
        {
            return base.AuditInfo() + " Text:" + this.Text;
        }


    }
}
