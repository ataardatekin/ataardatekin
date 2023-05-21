-- Ecommerce Project


--Ntier katmanl� mimari modelinde olu�turulacak

-Entity: Bu katman DAL katman� i�erisinde varl���n� s�rd�ren Context nesnesi taraf�ndan veritaban�na tablo haline gelecek olan classlar� bar�nd�r�r. Amac�m�z bu katman i�erisinde sadece entitylerin (veritaban� varl�klar�n�n) bar�nmas�n� sa�lamakt�r.

	--IEntity: B�t�n classlar taraf�ndanbar�nd�r�lacak propertyleri i�ermektedir. Ayr�ca bu interface generic bir yap�d�r. D��ar�dan bir tip alacakt�r. Alm�� oldu�u tip b�nyesinde bar�nd�rd��� propertylerin tipi haline gelecektir (iste�e ba�l� tabii);

	--BaseEntity: BaseEntity abstract bir class't�r. IEntity'de tan�mlu olan propertylerin somut nesnesidir. Ancak bu class'tan instance al�namayacak bu class a�a��da tan�ml� olan nesnelere �nc�l�k edecektir;


		--Product
		--Category
		--Supplier
		--AppUser
		--Order
		--OrderDetail
	--Enum: Proje genelinde entitylerde kullan�lacak olan sabitleri (Enum) i�ermektedir.



-DAL
	-Context:
		Context nesnesi i�erisinde bulunan OnModelCreating methodunda varsay�lan olarak �rnek verileri ilgili entitylere seed klas�r� i�erisinde tan�ml� olan classlar arac�l���yla iletildi. Bu sayede veritaban� her olu�turuldu�unda �rnek verilerle veritaban�n� aya�a kald�racak.

-BLL
-
-UI