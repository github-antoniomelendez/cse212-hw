public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public string Type { get; set; }
    public List<Feature> Features { get; set; }
}

public class Feature
{
    public string Type { get; set; }
    public FeatureProperties Properties { get; set; }
}

public class FeatureProperties
{
    public double Mag { get; set; }
    public string Place { get; set; }
}
