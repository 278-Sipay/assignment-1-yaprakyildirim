[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/0mNoXTBm)


## Fluent Validation HW

Person class icersindeki validation lar FluentValidation kutuphanesi kullanılması
Controller uzerindeki POST methodu attributelar yerinde FluentValidation ile çalışır.


1- FluentValidation kütüphanesini kullanarak belirli kurallar tanımlanmıştır:

2- Name ve Lastname: Ad ve soyadın boş olmamalı ve 5 ile 100 karakter arasında olmalıdır.
3- Phone: Telefon numarası boş olmamalı ve sadece rakamlardan oluşmalıdır.
4- AccessLevel: Erişim seviyesi 1 ile 5 arasında olmalıdır.
5- Salary: Maaş, erişim seviyesine göre belirlenen maksimum değeri aşmamalıdır (örn., seviye 1 için 10.000'e kadar) ve genel olarak 5.000 ile 50.000 arasında olmalıdır.
6- Bu kuralların dışında bir değer girilirse, belirtilen hata mesajları döndürülür. Bu, veri girişi sırasında uygunluk ve tutarlılık sağlamak için kullanılır.
