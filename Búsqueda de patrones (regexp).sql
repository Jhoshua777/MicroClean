----Buscar personas cuyo nombre comienza con "A"-----
SELECT * FROM Persona
WHERE PATINDEX('A%', Nombre) > 0;

---Buscar PERSONAS cuyos nombres contengan al menos una vocal doble----

SELECT * FROM Persona
JOIN Cargo ON Persona.id_person = Persona.id_person
WHERE PATINDEX('%[aeiou][aeiou]%', Persona.Nombre) > 0;

----SQL SERVER-------------------------------------------------BEST SGBD-----

