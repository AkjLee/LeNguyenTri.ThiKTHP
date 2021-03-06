package com.LNTri.jena;

import org.apache.jena.rdf.model.Model;
import org.apache.jena.rdf.model.ModelFactory;
import org.apache.jena.rdf.model.Property;
import org.apache.jena.rdf.model.Resource;
import org.apache.jena.rdfs.assembler.VocabRDFS;
import org.apache.jena.riot.system.Prefixes;
import org.apache.jena.sparql.vocabulary.FOAF;
import org.apache.jena.vocabulary.DC;
import org.apache.jena.vocabulary.RDF;
import org.apache.jena.vocabulary.SKOS;

import org.apache.jena.vocabulary.VCARD;

public class baithi {

	static Model creaModel() {
		// some definitions
		String personURI = "http://www.w3.org/Giangvien/LeMyCanh";
		String lamViecTaiIRI ="http://semanticweb-lear/lamViecTai";
		String KhoaIRI = "http://ww.w3.org/DHKH/Khoa/CNTT";
		String subjectIRI = "http://ww.w3.org/TruongDH";
		String SchoolIRI = "http://ww.w3.org/DHKH";
		String givenName = "Le";
		String familyName = "My Canh";
		String emailName = "LMCanh123@w3.org";
		String fullName = givenName + " " + familyName;
		
		//Sinh viên khoa K42
		String personURIK42 = "http://www.w3.org/Khoa/K42";
		String KhoaK42IRI1 = "http://ww.w3.org/LeNguyenTri";
		String givenName1 = "Le Nguyen";
		String familyName1 = "Tri";
		String mark1  =" 8.00";
		String emailName1 = "lnTri1@w3.org";
		String fullName1 = givenName1 + " " + familyName1;
		
		String KhoaK42IRI2 = "http://www.w3.org/TranVanHaiDuong";
		String givenName2 = "Tran Van Hai";
		String familyName2 = "Duong";
		String mark2  =" 8.50";
		String emailName2 = "tvhDuong3@w3.org";
		String fullName2 = givenName2 + " " + familyName2;
		
		String KhoaK42IRI3 = "http://ww.w3.org/NguyenKimNgan";
		String givenName3 = "Nguyen Kim"; String familyName3 = "Ngan";
		String mark3 =" 7.50"; 
		String emailName3 = "nkNgan2@w3.org";
		String fullName3 = givenName3 + " " + familyName3;

	
		//Sinh viên khoa K41
		String personURIK41 = "http://www.w3.org/Khoa/K41";
		String KhoaK41IRI4 = "http://www.w3.org/HuynhTienAnh";
		String givenName4 = "Huynh Tien";
		String familyName4 = "Anh";
		String mark4  =" 7.00";
		String emailName4 = "htAnh4@w3.org";
		String fullName4 = givenName4 + " " + familyName4;
		
		String KhoaK41IRI5 = "http://ww.w3.org/LuongVietBao";
		String givenName5 = "Luong Viet";
		String familyName5 = "Bao";
		String mark5  =" 8.50";
		String emailName5 = "lvBao5@w3.org";
		String fullName5 = givenName5 + " " + familyName5;
		
		// Sinh viên khoa K40
		String personURIK40 = "http://www.w3.org/Khoa/K40";
		String KhoaK40IRI6 = "http://ww.w3.org/TranThiNgocNhu";
		String givenName6 = "Tran Thi Ngoc";
		String familyName6 = "Nhu";
		String mark6  =" 7.50";
		String emailName6 = "ttnNhu6@w3.org";
		String fullName6 = givenName6 + " " + familyName6;
		
		// create an empty Model
		Model model1 = ModelFactory.createDefaultModel();

		// create the resource
		// and add the properties cascading style
		Resource lmc = model1.createResource(SchoolIRI);
			Property lamViectai=model1.createProperty(lamViecTaiIRI);
		Resource laGiangvien = model1.createResource(KhoaIRI);
			Property subject=model1.createProperty(subjectIRI);
			model1.createResource(SchoolIRI).
				addProperty(subject, model1.createResource(personURIK42)
						.addProperty(VCARD.FN, model1.createResource(KhoaK42IRI1)
							.addProperty(VCARD.NAME, (fullName1))
							.addProperty(RDF.predicate, (mark1))
							.addProperty(VCARD.EMAIL, (emailName1))).
						addProperty(VCARD.FN, model1.createResource(KhoaK42IRI2)
							.addProperty(VCARD.NAME, (fullName2))
							.addProperty(RDF.predicate, (mark2))
							.addProperty(VCARD.EMAIL, (emailName2))).
						addProperty(VCARD.FN, model1.createResource(KhoaK42IRI3)
							.addProperty(VCARD.NAME, (fullName3))
							.addProperty(RDF.predicate, (mark3))
							.addProperty(VCARD.EMAIL, (emailName3)))).
				addProperty(subject, model1.createResource(personURIK41).
						addProperty(VCARD.FN, model1.createResource(KhoaK41IRI4)
						.addProperty(VCARD.NAME, (fullName4))
						.addProperty(RDF.predicate, (mark4))
						.addProperty(VCARD.EMAIL, (emailName4))).
					addProperty(VCARD.FN, model1.createResource(KhoaK41IRI5)
						.addProperty(VCARD.NAME, (fullName5))
						.addProperty(RDF.predicate, (mark5))
						.addProperty(VCARD.EMAIL, (emailName5)))).
				addProperty(subject, model1.createResource(personURIK40).
						addProperty(VCARD.FN, model1.createResource(KhoaK40IRI6)
						.addProperty(VCARD.NAME, (fullName6))
						.addProperty(RDF.predicate, (mark6))
						.addProperty(VCARD.EMAIL, (emailName6))));
						
			lmc.addProperty(lamViectai, laGiangvien);
			lmc.addProperty(VCARD.ADR, (personURI));
			lmc.addProperty(VCARD.NAME, (fullName));
			lmc.addProperty( VCARD.EMAIL,(emailName));
			lmc.addProperty(DC.type, FOAF.Person);
			lmc.addProperty(FOAF.based_near,model1.createResource(personURIK42));
			return model1;
	}
///////////////////////////////////////////

	static void createAndPrintModel() {
		Model model1 =creaModel();
		// In nội dung của model dưới dạng mặc định (XML-RDF)
		model1.write(System.out);
	}
	
	public static void main(String[] args) {
		createAndPrintModel();
	}
}
