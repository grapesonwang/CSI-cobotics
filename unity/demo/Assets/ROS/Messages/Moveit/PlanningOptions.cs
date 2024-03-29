﻿/*
# The diff to consider for the planning scene (optional)
PlanningScene planning_scene_diff

# If this flag is set to true, the action
# returns an executable plan in the response but does not attempt execution  
bool plan_only

# If this flag is set to true, the action of planning &
# executing is allowed to look around  (move sensors) if
# it seems that not enough information is available about
# the environment
bool look_around

# If this value is positive, the action of planning & executing
# is allowed to look around for a maximum number of attempts;
# If the value is left as 0, the default value is used, as set
# with dynamic_reconfigure
int32 look_around_attempts

# If set and if look_around is true, this value is used as
# the maximum cost allowed for a path to be considered executable.
# If the cost of a path is higher than this value, more sensing or 
# a new plan needed. If left as 0.0 but look_around is true, then 
# the default value set via dynamic_reconfigure is used
float64 max_safe_execution_cost

# If the plan becomes invalidated during execution, it is possible to have
# that plan recomputed and execution restarted. This flag enables this
# functionality 
bool replan

# The maximum number of replanning attempts 
int32 replan_attempts

# The amount of time to wait in between replanning attempts (in seconds)
float64 replan_delay
*/

using Newtonsoft.Json;
using CSI.ROS.Messages.Standard;

namespace CSI.ROS.Messages.Moveit
{
    public class PlanningOptions : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "moveit_msgs/PlanningOptions";

        public PlanningScene planning_scene_diff;
        public Bool plan_only;
        public Bool look_around;
        public Int32 look_around_attempts;
        public Float64 max_safe_execution_cost;
        public Bool replan;
        public Int32 replan_attempts;
        public Float64 replan_delay;

        public PlanningOptions()
        {
            planning_scene_diff = new PlanningScene();
            plan_only = new Bool();
            look_around = new Bool();
            look_around_attempts = new Int32();
            max_safe_execution_cost = new Float64();
            replan = new Bool();
            replan_attempts = new Int32();
            replan_delay = new Float64();
        }
    }
}
