// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Maps.GeofenceExited event. </summary>
    public partial class MapsGeofenceExitedEventData : MapsGeofenceEventProperties
    {
        /// <summary> Initializes a new instance of <see cref="MapsGeofenceExitedEventData"/>. </summary>
        internal MapsGeofenceExitedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MapsGeofenceExitedEventData"/>. </summary>
        /// <param name="expiredGeofenceGeometryId"> Lists of the geometry ID of the geofence which is expired relative to the user time in the request. </param>
        /// <param name="geometries"> Lists the fence geometries that either fully contain the coordinate position or have an overlap with the searchBuffer around the fence. </param>
        /// <param name="invalidPeriodGeofenceGeometryId"> Lists of the geometry ID of the geofence which is in invalid period relative to the user time in the request. </param>
        /// <param name="isEventPublished"> True if at least one event is published to the Azure Maps event subscriber, false if no event is published to the Azure Maps event subscriber. </param>
        internal MapsGeofenceExitedEventData(IReadOnlyList<string> expiredGeofenceGeometryId, IReadOnlyList<MapsGeofenceGeometry> geometries, IReadOnlyList<string> invalidPeriodGeofenceGeometryId, bool? isEventPublished) : base(expiredGeofenceGeometryId, geometries, invalidPeriodGeofenceGeometryId, isEventPublished)
        {
        }
    }
}
