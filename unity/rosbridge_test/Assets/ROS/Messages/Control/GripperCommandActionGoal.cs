/*
Header header
actionlib_msgs/GoalID goal_id
GripperCommandGoal goal
*/

using Newtonsoft.Json;
using CSI.ROS.Messages.Standard;
using CSI.ROS.Messages.ActionLib;

namespace CSI.ROS.Messages.Control
{
    public class GripperCommandActionGoal : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "control_msgs/GripperCommandActionGoal";

        public Header header;
        public GoalID goal_id;
        public GripperCommandGoal goal;

        public GripperCommandActionGoal()
        {
            header = new Header();
            goal_id = new GoalID();
            goal = new GripperCommandGoal();
        }
    }
}

