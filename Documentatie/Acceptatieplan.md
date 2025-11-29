# Testcases – Kluisproject

Dit document bevat testcases (TC1 t/m TC17) op basis van de user story, use-cases en functionele requirements voor de digitale kluis.

Voor elke testcase worden doel, voorwaarden, input, uitvoering en verwacht resultaat beschreven.

------

[TOC]

---

## UC1 – Code instellen

### TC1 – Nieuwe toegangscode invoeren

| Eigenschap        | Beschrijving |
|-------------------|-------------|
| **ID**            | TC1 |
| **Doel**          | Controleren of de eigenaar een nieuwe toegangscode kan invoeren. |
| **Voorwaarden**   | Er is een kluis aanwezig zonder geldige code of met een bestaande code. |
| **Input**         | Nieuw gekozen toegangscode (bijv. "1234"). |
| **Actie**         | De eigenaar kiest de optie "code instellen" en voert de nieuwe code in. |
| **Verwacht resultaat** | De nieuwe code wordt geaccepteerd als invoer (nog zonder inhoudelijke validatie). |

### TC2 – Validatie van de toegangscode

| Eigenschap        | Beschrijving |
|-------------------|-------------|
| **ID**            | TC2 |
| **Doel**          | Controleren of de ingevoerde toegangscode wordt gevalideerd. |
| **Voorwaarden**   | De eigenaar kiest "code instellen". |
| **Input**         | Ongeldige code (bijv. lege string, te kort, of verboden tekens). |
| **Actie**         | De eigenaar voert een ongeldige code in. |
| **Verwacht resultaat** | De code wordt afgekeurd en de eigenaar krijgt een melding dat de code ongeldig is. De oude code blijft onveranderd. |

### TC3 – Opslaan van de nieuwe toegangscode

| Eigenschap        | Beschrijving |
|-------------------|-------------|
| **ID**            | TC3 |
| **Doel**          | Controleren of een geldige nieuwe code wordt opgeslagen als actuele kluiscode. |
| **Voorwaarden**   | De kluis is beschikbaar; er wordt een geldige code ingevoerd. |
| **Input**         | Geldige code (bijv. "5678"). |
| **Actie**         | De eigenaar voert de geldige code in en bevestigt het instellen. |
| **Verwacht resultaat** | De nieuwe code wordt opgeslagen als actuele toegangscode van de kluis. |

### TC4 – Bevestiging na instellen van de code

| Eigenschap        | Beschrijving |
|-------------------|-------------|
| **ID**            | TC4 |
| **Doel**          | Controleren of de eigenaar een bevestiging krijgt na het instellen van een geldige code. |
| **Voorwaarden**   | Geldige code is ingevoerd en opgeslagen. |
| **Input**         | Geldige code (bijv. "5678"). |
| **Actie**         | De eigenaar rondt het instelproces af. |
| **Verwacht resultaat** | De eigenaar ziet een duidelijke melding dat de toegangscode succesvol is ingesteld. |

---

## UC2 – Kluis openen

### TC5 – Code invoeren om kluis te openen

| Eigenschap        | Beschrijving |
|-------------------|-------------|
| **ID**            | TC5 |
| **Doel**          | Controleren of de eigenaar een toegangscode kan invoeren om de kluis te openen. |
| **Voorwaarden**   | Er is een geldige toegangscode ingesteld (bijv. "5678"). |
| **Input**         | "5678" |
| **Actie**         | De eigenaar kiest "kluis openen" en voert de code in. |
| **Verwacht resultaat** | De code wordt geaccepteerd als invoer voor het openingsproces. |

### TC6 – Vergelijken van ingevoerde code met opgeslagen code

| Eigenschap        | Beschrijving |
|-------------------|-------------|
| **ID**            | TC6 |
| **Doel**          | Controleren of de ingevoerde code wordt vergeleken met de opgeslagen code. |
| **Voorwaarden**   | Er is een opgeslagen code (bijv. "5678"). |
| **Input**         | Ingevoerde code: "5678". |
| **Actie**         | De eigenaar voert de juiste code in. |
| **Verwacht resultaat** | Het systeem bepaalt dat de ingevoerde code overeenkomt met de opgeslagen code. |

### TC7 – Kluis wordt geopend bij juiste code

| Eigenschap        | Beschrijving |
|-------------------|-------------|
| **ID**            | TC7 |
| **Doel**          | Controleren of de kluis wordt geopend wanneer de code klopt. |
| **Voorwaarden**   | Ingevoerde code is gelijk aan opgeslagen code. |
| **Input**         | Ingevoerde code: geldige code. |
| **Actie**         | De eigenaar bevestigt het openen. |
| **Verwacht resultaat** | De status van de kluis verandert naar "open"; de eigenaar kan nu voorwerpen plaatsen of pakken. |

### TC8 – Foutmelding bij verkeerde code

| Eigenschap        | Beschrijving |
|-------------------|-------------|
| **ID**            | TC8 |
| **Doel**          | Controleren of de eigenaar een foutmelding krijgt bij een onjuiste code. |
| **Voorwaarden**   | Er is een opgeslagen code (bijv. "5678"). |
| **Input**         | Ingevoerde code: "9999" (onjuist). |
| **Actie**         | De eigenaar voert een verkeerde code in. |
| **Verwacht resultaat** | De kluis blijft gesloten en de eigenaar ziet een duidelijke foutmelding over de onjuiste code. |

---

## UC3 – Voorwerpen plaatsen

### TC9 – Alleen plaatsen wanneer kluis geopend is

| Eigenschap        | Beschrijving |
|-------------------|-------------|
| **ID**            | TC9 |
| **Doel**          | Controleren dat er geen voorwerpen kunnen worden geplaatst wanneer de kluis gesloten is. |
| **Voorwaarden**   | Kluisstatus is "gesloten". |
| **Input**         | Poging om een voorwerp te plaatsen (bijv. "Horloge"). |
| **Actie**         | De eigenaar kiest "voorwerp plaatsen" terwijl de kluis dicht is. |
| **Verwacht resultaat** | Plaats-actie wordt geweigerd en de eigenaar krijgt een melding dat de kluis eerst geopend moet worden. |

### TC10 – Voorwerp toevoegen aan kluisinhoud

| Eigenschap        | Beschrijving |
|-------------------|-------------|
| **ID**            | TC10 |
| **Doel**          | Controleren of een voorwerp kan worden toegevoegd aan de kluisinhoud. |
| **Voorwaarden**   | De kluis is geopend. |
| **Input**         | Voorwerpnaam: "Horloge". |
| **Actie**         | De eigenaar kiest "voorwerp plaatsen" en voert de naam in. |
| **Verwacht resultaat** | Het voorwerp wordt toegevoegd aan de kluisinhoud. |

### TC11 – Opslaan van bijgewerkte kluisinhoud

| Eigenschap        | Beschrijving |
|-------------------|-------------|
| **ID**            | TC11 |
| **Doel**          | Controleren of de bijgewerkte kluisinhoud wordt vastgelegd. |
| **Voorwaarden**   | De kluis is open; ten minste één voorwerp wordt toegevoegd. |
| **Input**         | Voorwerpnaam: "Horloge". |
| **Actie**         | De eigenaar bevestigt het plaatsen van het voorwerp. |
| **Verwacht resultaat** | De nieuwe kluisinhoud wordt opgeslagen zodat het voorwerp later kan worden teruggevonden. |

### TC12 – Bevestiging na plaatsen van voorwerp

| Eigenschap        | Beschrijving |
|-------------------|-------------|
| **ID**            | TC12 |
| **Doel**          | Controleren of de eigenaar een bevestiging krijgt dat het voorwerp is geplaatst. |
| **Voorwaarden**   | Voorwerp is succesvol toegevoegd aan de inhoud. |
| **Input**         | Voorwerpnaam: "Horloge". |
| **Actie**         | De plaatsactie wordt afgerond. |
| **Verwacht resultaat** | De eigenaar ziet een melding dat het voorwerp succesvol is geplaatst. |

---

## UC4 – Voorwerpen pakken

### TC13 – Alleen pakken wanneer kluis geopend is

| Eigenschap        | Beschrijving |
|-------------------|-------------|
| **ID**            | TC13 |
| **Doel**          | Controleren dat er geen voorwerpen kunnen worden gepakt wanneer de kluis gesloten is. |
| **Voorwaarden**   | Kluisstatus is "gesloten"; er zijn voorwerpen aanwezig in de kluisinhoud. |
| **Input**         | Selectie van een bestaand voorwerp. |
| **Actie**         | De eigenaar probeert een voorwerp te pakken terwijl de kluis dicht is. |
| **Verwacht resultaat** | De actie wordt geweigerd en de eigenaar krijgt een melding dat de kluis eerst geopend moet worden. |

### TC14 – Voorwerp verwijderen uit kluisinhoud

| Eigenschap        | Beschrijving |
|-------------------|-------------|
| **ID**            | TC14 |
| **Doel**          | Controleren of een voorwerp kan worden verwijderd uit de kluisinhoud. |
| **Voorwaarden**   | Kluis is geopend; er zijn één of meer voorwerpen aanwezig. |
| **Input**         | Geselecteerd voorwerp (bijv. "Horloge"). |
| **Actie**         | De eigenaar kiest "voorwerp pakken" en selecteert het gewenste voorwerp. |
| **Verwacht resultaat** | Het gekozen voorwerp wordt uit de kluisinhoud verwijderd. |

### TC15 – Opslaan van aangepaste kluisinhoud

| Eigenschap        | Beschrijving |
|-------------------|-------------|
| **ID**            | TC15 |
| **Doel**          | Controleren of de aangepaste kluisinhoud wordt opgeslagen nadat een voorwerp is gepakt. |
| **Voorwaarden**   | Kluis is open; een bestaand voorwerp wordt verwijderd. |
| **Input**         | Geselecteerd voorwerp. |
| **Actie**         | De eigenaar rondt de actie "voorwerp pakken" af. |
| **Verwacht resultaat** | De nieuwe kluisinhoud (zonder het verwijderde voorwerp) wordt opgeslagen. |

### TC16 – Bevestiging na pakken van voorwerp

| Eigenschap        | Beschrijving |
|-------------------|-------------|
| **ID**            | TC16 |
| **Doel**          | Controleren of de eigenaar een bevestiging krijgt dat het voorwerp is gepakt. |
| **Voorwaarden**   | Voorwerp is succesvol uit de kluisinhoud verwijderd. |
| **Input**         | Geselecteerd voorwerp. |
| **Actie**         | De eigenaar rondt de pak-actie af. |
| **Verwacht resultaat** | De eigenaar ziet een melding dat het voorwerp succesvol is gepakt. |

---

## UC5 – Kluis sluiten

### TC17 – Kluis sluiten en vergrendelen

| Eigenschap        | Beschrijving |
|-------------------|-------------|
| **ID**            | TC17 |
| **Doel**          | Controleren of de kluis kan worden gesloten en vergrendeld. |
| **Voorwaarden**   | Kluis is geopend. |
| **Input**         | Actie: "kluis sluiten". |
| **Actie**         | De eigenaar kiest de optie om de kluis te sluiten. |
| **Verwacht resultaat** | De status van de kluis verandert naar "gesloten" en de toegang tot de inhoud is niet meer mogelijk zonder de juiste code. |

