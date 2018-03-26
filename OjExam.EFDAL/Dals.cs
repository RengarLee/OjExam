
﻿

 


using System;

using System.Collections.Generic;

using System.Data;

using System.Linq;

using System.Linq.Expressions;

using System.Text;

using System.Threading.Tasks;

using OjExam.IDAL;

using OjExam.Model;



namespace OjExam.EFDAL

{ 

		

	public partial class AdminDal:BaseDal<Admin>,IAdminDal

    {

	}

		

	public partial class ClassDal:BaseDal<Class>,IClassDal

    {

	}

		

	public partial class ClassTeacherCourserDal:BaseDal<ClassTeacherCourser>,IClassTeacherCourserDal

    {

	}

		

	public partial class CourserDal:BaseDal<Courser>,ICourserDal

    {

	}

		

	public partial class ExamDal:BaseDal<Exam>,IExamDal

    {

	}

		

	public partial class GradeDal:BaseDal<Grade>,IGradeDal

    {

	}

		

	public partial class KnowPointDal:BaseDal<KnowPoint>,IKnowPointDal

    {

	}

		

	public partial class ProblemDal:BaseDal<Problem>,IProblemDal

    {

	}

		

	public partial class StatusDal:BaseDal<Status>,IStatusDal

    {

	}

		

	public partial class StudentDal:BaseDal<Student>,IStudentDal

    {

	}

		

	public partial class TeacherDal:BaseDal<Teacher>,ITeacherDal

    {

	}


}