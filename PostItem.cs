using System;
using System.Collections.Generic;

namespace SARK_Chat2
{

	public partial class PostItem : UserControl
	{
        public PostItemModel Item { get; set; }
        public PostItem()
        {
            InitializeComponent();
            A = new PostItemModel
            {
                PhoneNumber = A.PhoneNumber,
                Body = A.Body,
                TimeSent = A.TimeSent
                //Body = new 
            };
        }

        //public PostItem(Dictionary<string, List<GetMessageInfoResponse>> conv)
        //{
        //    InitializeComponent();
        //}
        public class PostItemModel
        {
            public string PhoneNumber { get; set; }
            public string Body { get; set; }
            public string TimeSent { get; set; }

            
        }
    }
}
