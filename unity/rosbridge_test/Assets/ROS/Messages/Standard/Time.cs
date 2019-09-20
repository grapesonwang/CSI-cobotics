﻿
using Newtonsoft.Json;

namespace CSI.ROS.Messages.Standard
{
    public class Time : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "std_msgs/Time";
        public uint secs;
        public uint nsecs;

        public Time() { }
    }
}