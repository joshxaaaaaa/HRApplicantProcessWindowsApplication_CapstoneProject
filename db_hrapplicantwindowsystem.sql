# Created database with this exact name
CREATE DATABASE db_hrapplicantwindowsystem; 

# Use this database to add/remove/alter tables
USE db_hrapplicantwindowsystem;

# Created the first 15 required tables 
CREATE TABLE Roles ( role_id INT AUTO_INCREMENT PRIMARY KEY, role_name VARCHAR(50) NOT NULL UNIQUE, permissions TEXT, created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ); 

CREATE TABLE Departments ( department_id INT AUTO_INCREMENT PRIMARY KEY, department_name VARCHAR(100) NOT NULL UNIQUE, description TEXT, created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ); 

CREATE TABLE RequirementTypes ( requirement_type_id INT AUTO_INCREMENT PRIMARY KEY, requirement_name VARCHAR(100) NOT NULL, description TEXT ); 

CREATE TABLE Users ( user_id INT AUTO_INCREMENT PRIMARY KEY, username VARCHAR(50) NOT NULL UNIQUE, password_hash VARCHAR(255) NOT NULL, email VARCHAR(100) NOT NULL UNIQUE, role_id INT, created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP, FOREIGN KEY (role_id) REFERENCES Roles(role_id) ON DELETE SET NULL ); 

CREATE TABLE ApplicantAccounts ( account_id INT AUTO_INCREMENT PRIMARY KEY, email VARCHAR(100) NOT NULL UNIQUE, password_hash VARCHAR(255) NOT NULL, account_status ENUM('Active', 'Suspended', 'Deactivated') DEFAULT 'Active', created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ); 

CREATE TABLE Applicants ( applicant_id INT AUTO_INCREMENT PRIMARY KEY, account_id INT UNIQUE NOT NULL, first_name VARCHAR(50) NOT NULL, last_name VARCHAR(50) NOT NULL, contact_number VARCHAR(20), address TEXT, resume_url VARCHAR(255), FOREIGN KEY (account_id) REFERENCES ApplicantAccounts(account_id) ON DELETE CASCADE );

CREATE TABLE JobVacancies ( vacancy_id INT AUTO_INCREMENT PRIMARY KEY, department_id INT NOT NULL, job_title VARCHAR(100) NOT NULL, description TEXT, requirements TEXT, status ENUM('Open', 'Closed', 'On Hold') DEFAULT 'Open', posted_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP, FOREIGN KEY (department_id) REFERENCES Departments(department_id) ON DELETE CASCADE );

CREATE TABLE Applications ( application_id INT AUTO_INCREMENT PRIMARY KEY, applicant_id INT NOT NULL, vacancy_id INT NOT NULL, status ENUM('Submitted', 'Screening', 'Interviewing', 'Offered', 'Hired', 'Rejected') DEFAULT 'Submitted', applied_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP, FOREIGN KEY (applicant_id) REFERENCES Applicants(applicant_id) ON DELETE CASCADE, FOREIGN KEY (vacancy_id) REFERENCES JobVacancies(vacancy_id) ON DELETE CASCADE ); 

CREATE TABLE ApplicantDocuments ( document_id INT AUTO_INCREMENT PRIMARY KEY, application_id INT NOT NULL, requirement_type_id INT NOT NULL, file_path VARCHAR(255) NOT NULL, uploaded_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP, FOREIGN KEY (application_id) REFERENCES Applications(application_id) ON DELETE CASCADE, FOREIGN KEY (requirement_type_id) REFERENCES RequirementTypes(requirement_type_id) ON DELETE RESTRICT ); 

CREATE TABLE ScreeningResults ( screening_id INT AUTO_INCREMENT PRIMARY KEY, application_id INT NOT NULL, screened_by INT NOT NULL, result ENUM('Passed', 'Failed', 'Needs Review') NOT NULL, remarks TEXT, screened_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP, FOREIGN KEY (application_id) REFERENCES Applications(application_id) ON DELETE CASCADE, FOREIGN KEY (screened_by) REFERENCES Users(user_id) ON DELETE RESTRICT ); 

CREATE TABLE InterviewSchedules ( schedule_id INT AUTO_INCREMENT PRIMARY KEY, application_id INT NOT NULL, interviewer_id INT NOT NULL, interview_date DATETIME NOT NULL, location_mode VARCHAR(150) NOT NULL, created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP, FOREIGN KEY (application_id) REFERENCES Applications(application_id) ON DELETE CASCADE, FOREIGN KEY (interviewer_id) REFERENCES Users(user_id) ON DELETE RESTRICT ); 

CREATE TABLE InterviewEvaluations ( evaluation_id INT AUTO_INCREMENT PRIMARY KEY, schedule_id INT NOT NULL, score DECIMAL(5,2), result ENUM('Passed', 'Failed', 'Hold') NOT NULL, comments TEXT, evaluated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP, FOREIGN KEY (schedule_id) REFERENCES InterviewSchedules(schedule_id) ON DELETE CASCADE ); 

CREATE TABLE HiringDecisions ( decision_id INT AUTO_INCREMENT PRIMARY KEY, application_id INT NOT NULL UNIQUE, decision_maker_id INT NOT NULL, final_decision ENUM('Hired', 'Rejected', 'Waitlisted') NOT NULL, remarks TEXT, decision_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP, FOREIGN KEY (application_id) REFERENCES Applications(application_id) ON DELETE CASCADE, FOREIGN KEY (decision_maker_id) REFERENCES Users(user_id) ON DELETE RESTRICT );

CREATE TABLE ApplicationStatusHistory ( history_id INT AUTO_INCREMENT PRIMARY KEY, application_id INT NOT NULL, old_status VARCHAR(50), new_status VARCHAR(50) NOT NULL, changed_by INT, changed_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP, FOREIGN KEY (application_id) REFERENCES Applications(application_id) ON DELETE CASCADE, FOREIGN KEY (changed_by) REFERENCES Users(user_id) ON DELETE SET NULL ); 

CREATE TABLE AuditTrail ( audit_id INT AUTO_INCREMENT PRIMARY KEY, user_id INT,  action_type VARCHAR(100) NOT NULL, table_affected VARCHAR(50) NOT NULL, record_id INT, details TEXT, action_timestamp TIMESTAMP DEFAULT CURRENT_TIMESTAMP, FOREIGN KEY (user_id) REFERENCES Users(user_id) ON DELETE SET NULL ); 

# Created additional tables 
CREATE TABLE IF NOT EXISTS positions ( position_id INT AUTO_INCREMENT PRIMARY KEY, position_name VARCHAR(255) NOT NULL, description TEXT); 

CREATE TABLE IF NOT EXISTS employment_types ( employment_type_id INT AUTO_INCREMENT PRIMARY KEY, employment_name VARCHAR(255) NOT NULL, description TEXT );

CREATE TABLE IF NOT EXISTS interview_types ( interview_type_id INT AUTO_INCREMENT PRIMARY KEY, interview_name VARCHAR(255) NOT NULL, description TEXT );

CREATE TABLE IF NOT EXISTS assessment_types ( assessment_type_id INT AUTO_INCREMENT PRIMARY KEY, assessment_name VARCHAR(255) NOT NULL, description TEXT );

CREATE TABLE applicant_profiles (profile_id INT AUTO_INCREMENT PRIMARY KEY, applicant_id INT NOT NULL, educational_attainments TEXT, work_experiences TEXT, other_details TEXT, updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP, FOREIGN KEY (applicant_id) REFERENCES applicants(applicant_id) ON DELETE CASCADE );

# Alteration History 
ALTER TABLE departments MODIFY COLUMN created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP;

ALTER TABLE applications ADD COLUMN is_locked TINYINT(1) DEFAULT 0; 

ALTER TABLE Applications MODIFY COLUMN status ENUM('Submitted', 'Screening', 'Shortlisted', 'Interviewing', 'Offered', 'Hired', 'Rejected') DEFAULT 'Submitted'; 

ALTER TABLE ScreeningResults MODIFY COLUMN result ENUM('Qualified', 'Not Qualified', 'Passed', 'Failed', 'Needs Review') NOT NULL, MODIFY COLUMN screened_by INT NULL; 

ALTER TABLE interviewschedules ADD COLUMN interview_time TIME AFTER interview_date; 

ALTER TABLE interviewschedules ADD COLUMN interview_type_id INT AFTER interviewer_id; 

ALTER TABLE interviewschedules ADD COLUMN location VARCHAR(255) AFTER interview_type_id; 

ALTER TABLE interviewschedules ADD COLUMN status VARCHAR(50) DEFAULT 'Scheduled'; 

ALTER TABLE interviewevaluations ADD COLUMN application_id INT NOT NULL; 

ALTER TABLE interviewevaluations ADD COLUMN pass_fail VARCHAR(50) AFTER score; 

ALTER TABLE interviewevaluations ADD COLUMN recommendation VARCHAR(255) AFTER pass_fail; 

ALTER TABLE interviewevaluations ADD COLUMN remarks TEXT; 

ALTER TABLE interviewevaluations MODIFY COLUMN schedule_id INT NULL; 

ALTER TABLE jobvacancies RENAME COLUMN job_title TO position_name; 

ALTER TABLE positions ADD UNIQUE (position_name); 

ALTER TABLE jobvacancies ADD CONSTRAINT fk_job_position FOREIGN KEY (position_name) REFERENCES positions(position_name) ON UPDATE CASCADE; 

ALTER TABLE jobvacancies DROP FOREIGN KEY fk_job_position; 

SET FOREIGN_KEY_CHECKS = 0;

TRUNCATE TABLE jobvacancies;

SET FOREIGN_KEY_CHECKS = 1; 

ALTER TABLE jobvacancies DROP COLUMN position_name, DROP COLUMN description, ADD COLUMN position_id INT AFTER department_id; 

ALTER TABLE jobvacancies ADD CONSTRAINT fk_vacancy_position_id FOREIGN KEY (position_id) REFERENCES positions(position_id) ON UPDATE CASCADE; 

ALTER TABLE jobvacancies ADD COLUMN employment_type_id INT AFTER position_id, ADD COLUMN interview_type_id INT AFTER employment_type_id, ADD COLUMN assessment_type_id INT AFTER interview_type_id; 

ALTER TABLE jobvacancies ADD CONSTRAINT fk_job_employment FOREIGN KEY (employment_type_id) REFERENCES employment_types(employment_type_id) ON UPDATE CASCADE, ADD CONSTRAINT fk_job_interview FOREIGN KEY (interview_type_id) REFERENCES interview_types(interview_type_id) ON UPDATE CASCADE, ADD CONSTRAINT fk_job_assessment FOREIGN KEY (assessment_type_id) REFERENCES assessment_types(assessment_type_id) ON UPDATE CASCADE;

ALTER TABLE interviewschedules DROP COLUMN location_mode; 

ALTER TABLE applicationstatushistory DROP FOREIGN KEY applicationstatushistory_ibfk_2;

ALTER TABLE applicationstatushistory DROP COLUMN changed_by;  

ALTER TABLE interviewevaluations MODIFY COLUMN schedule_id INT; 

ALTER TABLE interviewevaluations ADD CONSTRAINT fk_evaluations_schedule FOREIGN KEY (schedule_id) REFERENCES interviewschedules(schedule_id) ON DELETE CASCADE ON UPDATE CASCADE; 

# Inserted HR Credentials 
INSERT IGNORE INTO Roles (role_name, permissions) VALUES ('HR Manager', 'Full Admin Access, Final Hiring Decisions'), ('HR Staff', 'Manage Jobs, Review Applicants, Schedule Interviews');  

INSERT INTO Users (username, password_hash, email, role_id) VALUES ('joshua', 'joshua123', 'joshua@company.com', (SELECT role_id FROM Roles WHERE role_name = 'HR Manager')), ('maryjoy', 'maryjoy123', 'maryjoy@company.com', (SELECT role_id FROM Roles WHERE role_name = 'HR Staff')), ('henry', 'henry123', 'henry@company.com', (SELECT role_id FROM Roles WHERE role_name = 'HR Staff')), ('sheena', 'sheena123', 'sheena@company.com', (SELECT role_id FROM Roles WHERE role_name = 'HR Staff')), ('shiela', 'shiela123', 'shiela@company.com', (SELECT role_id FROM Roles WHERE role_name = 'HR Staff')); 
