﻿using System;

namespace NewLife.Queue.Protocols.CenterServers.Requests
{
    [Serializable]
    public class SetQueueProducerVisibleForClusterRequest
    {
        public string ClusterName { get; set; }
        public string Topic { get; set; }
        public int QueueId { get; set; }
        public bool Visible { get; set; }
    }
}
