using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04_Encapsulation_Exercise4;


namespace _04_Encapsulation_UnitTests_4
{
    [TestClass]
    public class FreedomTests
    {
        private Developer _developer;
        private DeveloperRepository _developerRepository;
        private Course _course;
        private Course _course2;
        private Course _course3;
        private Course _course4;
        private Course _course5;
        private CourseRepository _courseRepository;
        [TestInitialize]
        public void Arrange()
        {
            _course = new Course("C# Fundamentals", 75m);
            _course2 = new Course("Inheritance", 50m);
            _course3 = new Course("C# Advanced", 80m);
            _course4 = new Course("Contoso", 42m);
            _courseRepository = new CourseRepository();
            _courseRepository.AddCourseToRepository(_course);
            _courseRepository.AddCourseToRepository(_course2);
            _courseRepository.AddCourseToRepository(_course3);
            _courseRepository.AddCourseToRepository(_course4);
            _developerRepository = new DeveloperRepository();
            //_developer = new Developer("John", new List<Course>(_course2, _course4), 25);
        }

        //[TestMethod]
        //public void CanAddCourse_CheckingCount()
        //{
        //    //Act
        //    var course = new Course("Foo", 50m);
        //    _courseRepository.AddCourseToRepository(course);
        //    var expected = 3;
        //    var actual = _courseRepository.GetListCount();

        //    //Assert
        //    Assert.AreEqual(expected, actual);


        //}

        [TestMethod]
        public void 
    }
}
