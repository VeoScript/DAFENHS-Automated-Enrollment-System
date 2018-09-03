Module ClearModule
    Public Sub RegistrationClearAll()
        RegisterAccount.txtIdNumber.Text = ""
        RegisterAccount.txtFullname.Text = ""
        RegisterAccount.cmbPosition.SelectedIndex = -1
        RegisterAccount.cmbAccountType.SelectedIndex = -1
        RegisterAccount.txtUsername.Text = ""
        RegisterAccount.txtPassword.Text = ""
        RegisterAccount.txtIdNumber.Focus()
    End Sub

    Public Sub LoginClearAll()
        Login.cmbLoginAs.SelectedIndex = -1
        Login.txtUsername.Text = ""
        Login.txtPassword.Text = ""
        Login.txtUsername.Focus()
    End Sub

    Public Sub ClearEnrollmentRegistration()

        Home.JuniorHighRegistration1.txtLRN.Text = ""
        Home.JuniorHighRegistration1.txtLastName.Text = ""
        Home.JuniorHighRegistration1.txtFirstName.Text = ""
        Home.JuniorHighRegistration1.txtMiddleName.Text = ""
        Home.JuniorHighRegistration1.cmbGender.SelectedIndex = -1
        Home.JuniorHighRegistration1.txtAge.Text = ""
        Home.JuniorHighRegistration1.txtAddress.Text = ""
        Home.JuniorHighRegistration1.dtpBirthDate.Text = Now
        Home.JuniorHighRegistration1.txtBirthPlace.Text = ""
        Home.JuniorHighRegistration1.txtFather.Text = ""
        Home.JuniorHighRegistration1.txtMother.Text = ""
        Home.JuniorHighRegistration1.txtGuardian.Text = ""
        Home.JuniorHighRegistration1.cmbRelationship.SelectedIndex = -1
        Home.JuniorHighRegistration1.picboxProfile.Image = Nothing  

        Home.SeniorHighRegistration1.txtLRN.Text = ""
        Home.SeniorHighRegistration1.txtLastName.Text = ""
        Home.SeniorHighRegistration1.txtFirstName.Text = ""
        Home.SeniorHighRegistration1.txtMiddleName.Text = ""
        Home.SeniorHighRegistration1.cmbGender.SelectedIndex = -1
        Home.SeniorHighRegistration1.txtAge.Text = ""
        Home.SeniorHighRegistration1.txtAddress.Text = ""
        Home.SeniorHighRegistration1.dtpBirthDate.Text = Now
        Home.SeniorHighRegistration1.txtBirthPlace.Text = ""
        Home.SeniorHighRegistration1.txtFather.Text = ""
        Home.SeniorHighRegistration1.txtMother.Text = ""
        Home.SeniorHighRegistration1.txtGuardian.Text = ""
        Home.SeniorHighRegistration1.cmbRelationship.SelectedIndex = -1
        Home.SeniorHighRegistration1.picboxProfile.Image = Nothing

        Home.Enrollment1.EnrollmentJuniorHigh1.picboxProfile.Image = Nothing
        Home.Enrollment1.EnrollmentJuniorHigh1.txtSearch.Clear()
        Home.Enrollment1.EnrollmentJuniorHigh1.txtLRN.Text = ""
        Home.Enrollment1.EnrollmentJuniorHigh1.txtLastName.Text = ""
        Home.Enrollment1.EnrollmentJuniorHigh1.txtFirstName.Text = ""
        Home.Enrollment1.EnrollmentJuniorHigh1.txtMiddleName.Text = ""
        Home.Enrollment1.EnrollmentJuniorHigh1.txtAddress.Text = ""
        Home.Enrollment1.EnrollmentJuniorHigh1.txtGender.Text = ""
        Home.Enrollment1.EnrollmentJuniorHigh1.txtAge.Text = ""
        Home.Enrollment1.EnrollmentJuniorHigh1.txtBirthDate.Text = ""
        Home.Enrollment1.EnrollmentJuniorHigh1.txtBirthPlace.Text = ""
        'Home.Enrollment1.EnrollmentJuniorHigh1.txtSchoolYear.Text = ""
        'Home.Enrollment1.EnrollmentJuniorHigh1.cmbGradeLevel.SelectedIndex = -1
        'Home.Enrollment1.EnrollmentJuniorHigh1.cmbSection.SelectedIndex = -1
        'Home.Enrollment1.EnrollmentJuniorHigh1.cmbAdvisory.SelectedIndex = -1
        Home.Enrollment1.EnrollmentJuniorHigh1.lblIdentifier.Text = ""

        Home.Enrollment1.EnrollmentSeniorHigh1.picboxProfile.Image = Nothing
        Home.Enrollment1.EnrollmentSeniorHigh1.txtSearch.Clear()
        Home.Enrollment1.EnrollmentSeniorHigh1.txtLRN.Text = ""
        Home.Enrollment1.EnrollmentSeniorHigh1.txtLastName.Text = ""
        Home.Enrollment1.EnrollmentSeniorHigh1.txtFirstName.Text = ""
        Home.Enrollment1.EnrollmentSeniorHigh1.txtMiddleName.Text = ""
        Home.Enrollment1.EnrollmentSeniorHigh1.txtAddress.Text = ""
        Home.Enrollment1.EnrollmentSeniorHigh1.txtGender.Text = ""
        Home.Enrollment1.EnrollmentSeniorHigh1.txtAge.Text = ""
        Home.Enrollment1.EnrollmentSeniorHigh1.txtBirthDate.Text = ""
        Home.Enrollment1.EnrollmentSeniorHigh1.txtBirthPlace.Text = ""
        'Home.Enrollment1.EnrollmentSeniorHigh1.txtSchoolYear.Text = ""
        'Home.Enrollment1.EnrollmentSeniorHigh1.cmbGradeLevel.SelectedIndex = -1
        'Home.Enrollment1.EnrollmentSeniorHigh1.cmbSection.SelectedIndex = -1
        'Home.Enrollment1.EnrollmentSeniorHigh1.cmbAdvisory.SelectedIndex = -1
        Home.Enrollment1.EnrollmentSeniorHigh1.cmbTrack.SelectedIndex = -1
        Home.Enrollment1.EnrollmentSeniorHigh1.lblIdentifier.Text = ""
    End Sub

    Public Sub RegistrationClear()
        Home.Registration1.RegisterTeacher1.txtIDNumber.Text = ""
        Home.Registration1.RegisterTeacher1.txtFullname.Text = ""
        Home.Registration1.RegisterTeacher1.cmbGender.SelectedIndex = -1
        Home.Registration1.RegisterTeacher1.cmbPosition.SelectedIndex = -1
        Home.Registration1.RegisterTeacher1.cmbRank.SelectedIndex = -1 

        Home.Registration1.RegisterSubject1.txtGradeLevel.Text = ""
        Home.Registration1.RegisterSubject1.txtSubject.Text = ""
        Home.Registration1.RegisterSubject1.cmbCategory.SelectedIndex = -1

        Home.Registration1.RegisterSection1.txtSection.Text = ""
        Home.Registration1.RegisterSection1.cmbCategory.SelectedIndex = -1
        Home.Registration1.RegisterSection1.cmbTrack.SelectedIndex = -1
    End Sub

    Public Sub ClassScheduleClear() 
        Home.ClassSchedule1.ClassSchedJuniorHigh1.dgSubjects.Columns.Clear()
        Home.ClassSchedule1.ClassSchedJuniorHigh1.txtGradeLevel.Text = ""
        Home.ClassSchedule1.ClassSchedJuniorHigh1.txtSchoolYear.Text = ""
        Home.ClassSchedule1.ClassSchedJuniorHigh1.cmbCategory.SelectedIndex = -1 
        Home.ClassSchedule1.ClassSchedJuniorHigh1.txtTime.Text = ""
        Home.ClassSchedule1.ClassSchedJuniorHigh1.dgScheduleLoader.Rows.Clear()
        Home.ClassSchedule1.ClassSchedJuniorHigh1.txtIdentIdentifier.Text = ""
        Home.ClassSchedule1.ClassSchedJuniorHigh1.txtSection.Text = ""
        Home.ClassSchedule1.ClassSchedJuniorHigh1.cmbTrack.SelectedIndex = -1
        Home.ClassSchedule1.ClassSchedJuniorHigh1.cmbTrack.Enabled = False
    End Sub

    Public Sub ClearSearch()
        Home.Search1.cmbCategory.SelectedIndex = -1
        Home.Search1.cmbTrack.SelectedIndex = -1
        Home.Search1.txtSchoolYear.Text = ""
        Home.Search1.txtGradeLevel.Text = ""
        Home.Search1.txtSection.Text = ""
        Home.Search1.dgClassList.Columns.Clear()

        Home.Search1.cmbPopulationCategory.SelectedIndex = -1
        'Home.Search1.cmbPopulationTrack.SelectedIndex = -1
        Home.Search1.txtSchoolYearPopulation.Text = ""
        'Home.Search1.txtGradeLevelPopulation.Text = ""
        'Home.Search1.txtSectionPopulation.Text = ""
        Home.Search1.dgPopulation.Columns.Clear()
        Home.Search1.lblMale.Text = ""
        Home.Search1.lblFemale.Text = ""
        Home.Search1.lblTotal.Text = ""
    End Sub
End Module
