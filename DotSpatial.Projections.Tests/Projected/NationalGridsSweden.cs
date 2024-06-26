using System.Collections.Generic;
using NUnit.Framework;
using DotSpatial.Projections;

namespace DotSpatial.Projections.Tests.Projected
{
    /// <summary>
    /// This class contains all the tests for the NationalGridsSweden category of Projected coordinate systems
    /// </summary>
    [TestFixture]
    public class NationalGridsSweden
    {
        [Test]
        [TestCaseSource("GetProjections")]
        public void NationalGridsSwedenTests(ProjectionInfoDesc pInfo)
        {
            Tester.TestProjection(pInfo.ProjectionInfo);
        }

        private static IEnumerable<ProjectionInfoDesc> GetProjections()
        {
            return ProjectionInfoDesc.GetForCoordinateSystemCategory(KnownCoordinateSystems.Projected.NationalGridsSweden);
        }
    }
}