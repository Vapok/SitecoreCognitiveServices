﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.ProjectOxford.Emotion.Contract;
using Microsoft.ProjectOxford.Face.Contract;

namespace Sitecore.SharedSource.CognitiveServices.LaunchDemo.Models
{
    public class FaceResult
    {
        public Face[] Result { get; set; }
        public string ImageUrl { get; set; }
    }
}