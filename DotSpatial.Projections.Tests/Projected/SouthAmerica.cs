
using NUnit.Framework;
using DotSpatial.Projections;

namespace DotSpatial.Projections.Tests.Projected
{
    /// <summary>
    /// This class contains all the tests for the SouthAmerica category of Projected coordinate systems
    /// </summary>
    [TestFixture]
    public class SouthAmerica
    {
        /// <summary>
        /// Creates a new instance of the Africa Class
        /// </summary>
        [TestFixtureSetUp]
        public void Initialize()
        {
            
        }

        [Test]
        public void SouthAmericaAlbersEqualAreaConic()
        {
            ProjectionInfo pStart = KnownCoordinateSystems.Projected.SouthAmerica.SouthAmericaAlbersEqualAreaConic;
            Tester.TestProjection(pStart);
        }


        [Test]
        public void SouthAmericaEquidistantConic()
        {
            ProjectionInfo pStart = KnownCoordinateSystems.Projected.SouthAmerica.SouthAmericaEquidistantConic;
            Tester.TestProjection(pStart);
        }


        [Test]
        public void SouthAmericaLambertConformalConic()
        {
            ProjectionInfo pStart = KnownCoordinateSystems.Projected.SouthAmerica.SouthAmericaLambertConformalConic;
            Tester.TestProjection(pStart);
        }
    }
}