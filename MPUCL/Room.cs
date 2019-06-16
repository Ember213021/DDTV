using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPUCL
{
    public class Room
    {
        public class RoomBox
        {
            public List<RoomCadr> data { get; set; }
        }

        public class RoomCadr
        {
            public string Name { get; set; }
            public string RoomNumber { get; set; }
            private string types= "bilibili";

            public string Types
            {
                get { return types; }
                set { types = value; }
            }
           
            private bool status =false;

            public bool Status
            {
                get { return status; }
                set { status = value; }
            }

            private bool videoStatus = false;

            public bool VideoStatus
            {
                get { return videoStatus; }
                set { videoStatus = value; }
            }
            

            [JsonProperty(PropertyName = "Ty")]
            private bool statusAlt1 { set { status = value;} }
        }

        /// <summary>
        /// 房间的动态数据
        /// </summary>
        public class RoomInfo
        {
            public string Name { get; set; }
            public string RoomNumber { get; set; }
            public string Text { get; set; }
            public string steam { get; set; }
            public bool status { get; set; }
            public bool Top { get; set; }

        }

        public class RecordVideo
        {
            public string guid { get; set; }
            public string RoomID { get; set; }
            public string Name { get; set; }
            public bool Status { get; set; }
            public string File { get; set; }
            private string startTime = "";

            public string StartTime
            {
                get { return startTime; }
                set { startTime = value; }
            }
            private string endTime = "";

            public string EndTime
            {
                get { return endTime; }
                set { endTime = value; }
            }
            
        }
    }
}
