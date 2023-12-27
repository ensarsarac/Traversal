﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.CQRS.Results.DestinationResults
{
    public class GetDestinatonByIdQueryResult
    {
        public int Destinationid { get; set; }
        public string City { get; set; }
        public string Daynight { get; set; }
        public int Capacity { get; set; }
        public double Price{ get; set; }
    }
}
