﻿using System.Web.Script.Serialization;

namespace Sitecore.SharedSource.CognitiveServices.Search.ComputedFields.Image
{
    public class EmotionAnalysis : BaseComputedField
    {
        protected override object GetFieldValue(CognitiveIndexableItem cognitiveIndexable)
        {
            if (cognitiveIndexable.Emotions == null)
            {
                return null;
            }

            var json = new JavaScriptSerializer().Serialize(cognitiveIndexable.Emotions);
            return json;
        }
    }
}