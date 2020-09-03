package com.jsf.jpa.crud.db.operations;

import java.util.List;

import javax.faces.application.FacesMessage;
import javax.faces.context.FacesContext;
import javax.persistence.EntityManager;
import javax.persistence.EntityTransaction;
import javax.persistence.Persistence;
import javax.persistence.Query;

import com.jsf.jpa.crud.SchoolBean;
import com.jsf.jpa.crud.SchoolEntityManager;

public class DatabaseOperations {

	private static final String PERSISTENCE_UNIT_NAME = "JSFJPACrud";	
	private static EntityManager entityMgrObj = Persistence.createEntityManagerFactory(PERSISTENCE_UNIT_NAME).createEntityManager();
	private static EntityTransaction transactionObj = entityMgrObj.getTransaction();

	// Method To Fetch All School Details From The Database
	@SuppressWarnings("unchecked")
	public static List<SchoolBean> getAllSchoolDetails() {
		Query queryObj = entityMgrObj.createQuery("SELECT s FROM SchoolEntityManager s");
		List<SchoolBean> schoolList = queryObj.getResultList();
		if (schoolList != null && schoolList.size() > 0) {			
			return schoolList;
		} else {
			return null;
		}
	}

	// Method To Add Create School Details In The Database
	public static String createNewSchool(String name) {
		if(!transactionObj.isActive()) {
			transactionObj.begin();
		}

		SchoolEntityManager newSchoolObj = new SchoolEntityManager();
		newSchoolObj.setId(getMaxSchoolId());
		newSchoolObj.setName(name);
		entityMgrObj.persist(newSchoolObj);
		transactionObj.commit();
		return "schoolsList.xhtml?faces-redirect=true";	
	}

	// Method To Delete The Selected School Id From The Database 
	public static String deleteSchoolDetails(int schoolId) {
		if (!transactionObj.isActive()) {
			transactionObj.begin();
		}

		SchoolEntityManager deleteSchoolObj = new SchoolEntityManager();
		if(isSchoolIdPresent(schoolId)) {
			deleteSchoolObj.setId(schoolId);
			entityMgrObj.remove(entityMgrObj.merge(deleteSchoolObj));
		}		
		transactionObj.commit();
		return "schoolsList.xhtml?faces-redirect=true";
	}

	// Method To Update The School Details For A Particular School Id In The Database
	public static String updateSchoolDetails(int schoolId, String updatedSchoolName) {
		if (!transactionObj.isActive()) {
			transactionObj.begin();
		}

		if(isSchoolIdPresent(schoolId)) {
			Query queryObj = entityMgrObj.createQuery("UPDATE SchoolEntityManager s SET s.name=:name WHERE s.id= :id");			
			queryObj.setParameter("id", schoolId);
			queryObj.setParameter("name", updatedSchoolName);
			int updateCount = queryObj.executeUpdate();
			if(updateCount > 0) {
				System.out.println("Record For Id: " + schoolId + " Is Updated");
			}
		}
		transactionObj.commit();
		FacesContext.getCurrentInstance().addMessage("editSchoolForm:schoolId", new FacesMessage("School Record #" + schoolId + " Is Successfully Updated In Db"));
		return "schoolEdit.xhtml";
	}

	// Helper Method 1 - Fetch Maximum School Id From The Database
	private static int getMaxSchoolId() {
		int maxSchoolId = 1;
		Query queryObj = entityMgrObj.createQuery("SELECT MAX(s.id)+1 FROM SchoolEntityManager s");
		if(queryObj.getSingleResult() != null) {
			maxSchoolId = (Integer) queryObj.getSingleResult();
		}
		return maxSchoolId;
	}

	// Helper Method 2 - Fetch Particular School Details On The Basis Of School Id From The Database
	private static boolean isSchoolIdPresent(int schoolId) {
		boolean idResult = false;
		Query queryObj = entityMgrObj.createQuery("SELECT s FROM SchoolEntityManager s WHERE s.id = :id");
		queryObj.setParameter("id", schoolId);
		SchoolEntityManager selectedSchoolId = (SchoolEntityManager) queryObj.getSingleResult();
		if(selectedSchoolId != null) {
			idResult = true;
		}
		return idResult;
	}
}