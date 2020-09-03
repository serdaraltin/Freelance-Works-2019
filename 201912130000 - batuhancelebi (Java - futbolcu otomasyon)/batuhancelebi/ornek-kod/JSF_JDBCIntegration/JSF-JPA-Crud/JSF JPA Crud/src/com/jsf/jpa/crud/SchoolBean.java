package com.jsf.jpa.crud;

import java.util.List;

import javax.faces.bean.ManagedBean;
import javax.faces.context.FacesContext;

import com.jsf.jpa.crud.db.operations.DatabaseOperations;

@ManagedBean
public class SchoolBean {

	private int id;
	private String name;	
	private String editSchoolId;

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getEditSchoolId() {
		return editSchoolId;
	}

	public void setEditSchoolId(String editSchoolId) {
		this.editSchoolId = editSchoolId;
	}

	// Method To Fetch The Existing School List From The Database
	public List<SchoolBean> schoolListFromDb() {
		return DatabaseOperations.getAllSchoolDetails();		
	}

	// Method To Add New School To The Database
	public String addNewSchool(SchoolBean schoolBean) {
		return DatabaseOperations.createNewSchool(schoolBean.getName());		
	}

	// Method To Delete The School Details From The Database
	public String deleteSchoolById(int schoolId) {		
		return DatabaseOperations.deleteSchoolDetails(schoolId);		
	}

	// Method To Navigate User To The Edit Details Page And Passing Selecting School Id Variable As A Hidden Value
	public String editSchoolDetailsById() {
		editSchoolId = FacesContext.getCurrentInstance().getExternalContext().getRequestParameterMap().get("selectedSchoolId");		
		return "schoolEdit.xhtml";
	}

	// Method To Update The School Details In The Database
	public String updateSchoolDetails(SchoolBean schoolBean) {
		return DatabaseOperations.updateSchoolDetails(Integer.parseInt(schoolBean.getEditSchoolId()), schoolBean.getName());		
	}
}