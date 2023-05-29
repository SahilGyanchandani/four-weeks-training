// Student object
const student = {
    name: "",
    gradeLevel: "",
    courses: [],
  
    addCourse: function(course) {
      this.courses.push(course);
    },
  
    removeCourse: function(course) {
      const index = this.courses.indexOf(course);
      if (index !== -1) {
        this.courses.splice(index, 1);
      }
    },
  
    updateInfo: function() {
      document.getElementById("studentName").textContent = this.name;
      document.getElementById("studentGrade").textContent = this.gradeLevel;
      document.getElementById("studentCourses").textContent = this.courses.join(", ");
    }
  };
  
  function addCourse() {
    const courseInput = document.getElementById("course").value;
    student.addCourse(courseInput);
    student.updateInfo();
    document.getElementById("course").value = "";
  }
  
  function removeCourse() {
    const selectElement = document.getElementById("removeCourse");
    const courseToRemove = selectElement.value;
    student.removeCourse(courseToRemove);
    student.updateInfo();
    selectElement.remove(selectElement.selectedIndex);
  }
  
  document.getElementById("name").addEventListener("input", function() {
    student.name = this.value;
    student.updateInfo();
  });
  
  document.getElementById("grade").addEventListener("input", function() {
    student.gradeLevel = this.value;
    student.updateInfo();
  });
  