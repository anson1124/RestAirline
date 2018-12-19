﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RestAirline.Api.Controllers;
using RestAirline.Api.Hypermedia;
using RestAirline.Domain.Booking;

namespace RestAirline.Api.Resources.Booking
{
    public class SelectTripCommand : HypermediaCommand<TripSelectionResource>
    {
        [Obsolete("For serialization")]
        public SelectTripCommand() { }

        public SelectTripCommand(IUrlHelper urlHelper) : base(urlHelper.Link((BookingController c) => c.SelectTrip(null)))
        {
            Passengers = new List<Passenger>();
        }

        public SelectTripCommand(Link<TripSelectionResource> postUrl) : base(postUrl)
        {
            Passengers = new List<Passenger>();
        }

        public List<Passenger> Passengers { get; set; }
        public Trip Trip { get; set; }
    }
}