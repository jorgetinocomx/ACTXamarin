﻿namespace TaskMobile.WebServices.Entities
{
    /// <summary>
    /// Activity body response.
    /// </summary>
    /// <remarks>
    /// Used for make a web service response . 
    ///     The properties of this class are the <see cref="Common.Response{T}.MessageBody"/>.
    /// </remarks>
    public class ActivityResponse
    {
        /// <summary>
        /// Contains all the activities for  the requested task.
        /// </summary>
        public ActivityResult QueryTaskActivitiesResult { get; set; }
    }
}