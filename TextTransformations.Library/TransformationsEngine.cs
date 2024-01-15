namespace TextTransformations.Library
{
    public static class TransformationEngine
    {
        public static string ApplyAll(string text, params TextTransformations[] transformations)
        {
            string result = text;
            foreach (var transformation in transformations)
            {
                result = transformation.Apply(result);
            }

            return result;
        }
    }
}