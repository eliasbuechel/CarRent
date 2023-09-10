# Dokumentation CarRent

<h1> INFO: mkdocs gh-deploy - Deploys The Page on Github<h1>

**Einführung**

Es soll ein neues Autovermietungssystem „CarRent“ erstellt werden. Das System soll aus einem Server-Teil und optional einen Web-Client bestehen.<br/><br/>
a) Die Daten sollen mittels Repository Pattern in eine Datenbank gespeichert werden können.<br/>
b) Die Business Logik soll auf dem Backend laufen und eine REST APIs anbieten.<br/>
c) Es soll zuerst ein Monolith erstellt werden und später auf eine Micro Service Architektur überführt werden.<br/><br/>
Optional:<br/>
d) Der Web-Client benutzt die REST API um die Funktionen auszuführen.
Folgende Detailinformationen liegen unstrukturiert über das zu entwickelnde System vor:<br/><br/><br/>

• Der Sachbearbeiter kann Kunden mit Namen und Adresse und Kundennummer im System verwalten, d.h. erfassen, bearbeiten, löschen und den Kunden mit dessen Namen oder Kundennummer suchen.<br/><br/>

• Der Sachbearbeiter kann zudem die Autos von CarRent verwalten und nach denen suchen.<br/><br/>

• Jedes Auto kann einer bestimmten Klasse zwischen Luxusklasse, Mittelklasse oder Einfachklasse zugeordnet werden und besitzt zudem eine Marke, einen Typ und eine eindeutige Identifikation.<br/><br/>

• Jede Klasse besitzt eine Tagesgebühr.<br/><br/>

• Bei einer neuen Reservation kann der Kunde ein Auto aus einer bestimmten Klasse wählen. Er muss zudem die Anzahl der Tage angeben, die er das Auto gerne mieten möchte. Dabei werden die Gesamtkosten berechnet. Wird die Reservation gespeichert, so wird sie mit einer Reservationsnummer ablegt.<br/><br/>

• Bei Abholung des Autos wird die Reservation in einen Mietvertrag umgewandelt.<br/><br/>

**DomainModel**

<img src="/images/DomainModel.png" alt="Domain Modell"/>