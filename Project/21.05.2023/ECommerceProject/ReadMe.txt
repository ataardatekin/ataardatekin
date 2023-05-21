-- Ecommerce Project


--Ntier katmanlý mimari modelinde oluþturulacak

-Entity: Bu katman DAL katmaný içerisinde varlýðýný sürdüren Context nesnesi tarafýndan veritabanýna tablo haline gelecek olan classlarý barýndýrýr. Amacýmýz bu katman içerisinde sadece entitylerin (veritabaný varlýklarýnýn) barýnmasýný saðlamaktýr.

	--IEntity: Bütün classlar tarafýndanbarýndýrýlacak propertyleri içermektedir. Ayrýca bu interface generic bir yapýdýr. Dýþarýdan bir tip alacaktýr. Almýþ olduðu tip bünyesinde barýndýrdýðý propertylerin tipi haline gelecektir (isteðe baðlý tabii);

	--BaseEntity: BaseEntity abstract bir class'týr. IEntity'de tanýmlu olan propertylerin somut nesnesidir. Ancak bu class'tan instance alýnamayacak bu class aþaðýda tanýmlý olan nesnelere öncülük edecektir;


		--Product
		--Category
		--Supplier
		--AppUser
		--Order
		--OrderDetail
	--Enum: Proje genelinde entitylerde kullanýlacak olan sabitleri (Enum) içermektedir.



-DAL
	-Context:
		Context nesnesi içerisinde bulunan OnModelCreating methodunda varsayýlan olarak örnek verileri ilgili entitylere seed klasörü içerisinde tanýmlý olan classlar aracýlýðýyla iletildi. Bu sayede veritabaný her oluþturulduðunda örnek verilerle veritabanýný ayaða kaldýracak.

-BLL
-
-UI