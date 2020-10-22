using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using RingCentral;
using System.Text.RegularExpressions;

namespace SARK_Chat2
{
    public partial class PostItem : UserControl
    {
        public PostItemModel Item { get; set; }
        public PostItem()
        {
            InitializeComponent();
        }

        public PostItem(RingCentral.GetMessageInfoResponse item)
        {
            InitializeComponent();
            DateTime sentTime = DateTime.Parse(item.creationTime);
            var timeSpan = (DateTime.Now-sentTime).TotalMilliseconds;
            string timeSent;
            string spacing = "   ";
            if (timeSpan > 43200000)
            {
                timeSent = sentTime.ToShortDateString();
            }
            else
            {
                timeSent = sentTime.ToShortTimeString();
            }
            Item = new PostItemModel
            {
                Body = item.subject.Replace("Test SMS using a RingCentral Developer account - ", ""),
                TimeSent = timeSent,
                PhoneNumber = item.from.phoneNumber
            };
            
            // The following content deals with sizing/docking the controls.

            DockStyle dStyle;
            HorizontalAlignment hAlign;
            //string bodyWithSpacing;
            //string timeWithSpacing;
            ContentAlignment LRSide;
            var newLinePattern = @"(\n|\r\n?)";

            var newLineCount = Regex.Matches(Item.Body, newLinePattern).Count;
            if (Item.PhoneNumber=="+12055824906")
            {
                
                dStyle = DockStyle.Right;
                hAlign = HorizontalAlignment.Right;
                //bodyWithSpacing = Item.Body + spacing;
                //timeWithSpacing = Item.TimeSent.ToString() + spacing;
                LRSide = ContentAlignment.BottomRight;
            }
            else
            {
                MessageBody.BackColor = Color.LightGray;
                RoundedPanel.BackColor = Color.LightGray;
                dStyle = DockStyle.Left;
                hAlign = HorizontalAlignment.Left;
                //bodyWithSpacing = spacing + Item.Body;
                //timeWithSpacing = spacing + Item.TimeSent.ToString();
                LRSide = ContentAlignment.BottomLeft;
            }
            int TBWidth = Math.Max(Item.Body.Length * 6 + 15, 100);
            int TBHeight = Math.Max(Item.Body.Length / 30, 10);

            MessageBody.Text = Item.Body;
            TimeSentLabel.Text = Item.TimeSent;
            
            TimeSentLabel.BackColor = Color.Transparent;
            MessageBody.Dock = DockStyle.Top;
            MessageBody.Height = TBHeight + 150;
            TimeSentLabel.TextAlign = LRSide;
            TimeSentLabel.Dock = DockStyle.Bottom;
            MessageBody.TextAlign = hAlign;
            //RoundedPanel.Height = TBHeight + 60;
            RoundedPanel.Width = Math.Min(TBWidth, 198);
            RoundedPanel.Size = new Size(Math.Min(TBWidth, 200), TBHeight);
            //RoundedPanel.Controls.Add(TimeSentLabel);
            RoundedPanel.Controls.Add(MessageBody);
            RoundedPanel.Dock = dStyle;
            PostContainer.Size = new Size(198, 300);
            PostContainer.Dock = dStyle;
            PostContainer.Controls.Add(RoundedPanel);
            PostContainer.Controls.Add(TimeSentLabel);

        }
    }
    public class PostItemModel
    {
        public string Body { get; set; }
        public string PhoneNumber { get; set; }
        public string TimeSent { get; set; }
    }
}
