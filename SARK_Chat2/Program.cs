using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RingCentral;
using Newtonsoft.Json;
using RingCentral.Paths.Restapi.Subscription;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SARK_Chat2
{
    static class Program
    {
        const string RINGCENTRAL_CLIENTID = "1qlf2Vq3Q6C2zBQu9hT1lA";
        const string RINGCENTRAL_CLIENTSECRET = "7z5bjyOxTdC89dInbH-fgQq4euYtJiSTqVM9XzX3yg1Q";
        const bool RINGCENTRAL_PRODUCTION = false;

        const string RINGCENTRAL_USERNAME = "+12055824906";
        const string RINGCENTRAL_PASSWORD = "sandbox15#";
        const string RINGCENTRAL_EXTENSION = "101";

        static RestClient rc;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static public async Task send_sms(string cNumber, string message)
        {
            rc = new RestClient(RINGCENTRAL_CLIENTID, RINGCENTRAL_CLIENTSECRET, RINGCENTRAL_PRODUCTION);
            await rc.Authorize(RINGCENTRAL_USERNAME, RINGCENTRAL_EXTENSION, RINGCENTRAL_PASSWORD);
            if (rc.token.access_token.Length > 0)
            {
                var parameters = new CreateSMSMessage();
                parameters.from = new MessageStoreCallerInfoRequest { phoneNumber = RINGCENTRAL_USERNAME };
                parameters.to = new MessageStoreCallerInfoRequest[] { new MessageStoreCallerInfoRequest { phoneNumber = cNumber } };
                parameters.text = message;

                var resp = await rc.Restapi().Account().Extension().Sms().Post(parameters);
                Console.WriteLine("SMS sent. Message status: " + resp.messageStatus);
            }
            else Console.WriteLine("There was an issue.");
        }

        static public async Task<Dictionary<string, List<GetMessageInfoResponse>>> read_messages(string cNumber)
        {

            RestClient rc = new RestClient(RINGCENTRAL_CLIENTID, RINGCENTRAL_CLIENTSECRET, false);
            await rc.Authorize(RINGCENTRAL_USERNAME, RINGCENTRAL_EXTENSION, RINGCENTRAL_PASSWORD);

            ListMessagesParameters pars = new ListMessagesParameters
            {
                //availability = new[] { "Alive", "Deleted", "Purged" },
                //conversationId = 000,
                dateFrom = "2020-06-06T18:07:52.534Z",
                //dateTo = "<ENTER VALUE>",
                //direction = new[] { "Inbound" },
                //distinctConversations = true,
                messageType = new[] { "Fax", "SMS", "VoiceMail", "Pager", "Text" },
                //readStatus = new[] { "Read", "Unread" },
                //page = 1,
                //perPage = 100,
                phoneNumber = "+1" + cNumber
            };

            var r = await rc.Restapi().Account().Extension().MessageStore().List(pars);

            Dictionary<string, List<GetMessageInfoResponse>> textsByPhoneNumber = new Dictionary<string, List<GetMessageInfoResponse>>();

            foreach (var el in r.records)
            {
                // determine the client's number
                string clientNumber;
                if (el.direction == "Outbound")
                {
                    // the "to" returns an array; this only retrieves the first in the array
                    clientNumber = el.to[0].phoneNumber;
                }
                else
                {
                    clientNumber = el.from.phoneNumber;
                }

                //add functions for attachments

                // if the key doesn't already exist in the dictionary
                List<GetMessageInfoResponse> msgList;
                if (!textsByPhoneNumber.TryGetValue(clientNumber, out msgList))
                {
                    msgList = new List<GetMessageInfoResponse>();
                    textsByPhoneNumber.Add(clientNumber, msgList);
                }
                textsByPhoneNumber[clientNumber].Add(el);
                textsByPhoneNumber[clientNumber].Reverse();

            }

            return textsByPhoneNumber;
        }
    }
}
