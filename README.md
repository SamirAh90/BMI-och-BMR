# BMI-och-BMR
BMI och BMR-räknare i C#
Dokumentation för BMI och BMR-räknare i C#
Detta dokument beskriver en C#-kod som implementerar en BMI (Body Mass Index)- och BMR (Basal Metabolic Rate)-räknare. 
Koden beräknar först BMI och låter användaren ange sin vikt och längd och beräknar sedan BMI-värdet enligt WHO-formulan. Därefter skriver den ut en BMI-värdet och personens vikt enligt BMI-tabellen.
Koden beräknar sedan BMR och begär användaren att ange sin vikt, längd, ålder och kön för att beräkna BMR enligt Mifflin-St Jeor-ekvationen. Sedan skriver programmet ut både BMR. Koden har IF sats och har två olika formulaner baserad på kön. Programmet kontrollerar också att de inmatade värdena är inom giltiga intervall för att undvika felaktiga resultat. Om användaren anger ogiltiga värden skrivs ett felmeddelande ”Ogiltig val!” ut.

Funktionalitet
Koden börjar med att hälsa användaren välkommen till BMI- och BMR-räknaren genom att skriva ut ett välkomstmeddelande.
Därefter skriver om BMI räknare enlgit WHO
Användaren ombeds ange sin vikt (i kg) och längd (i meter, med möjlighet att använda decimaler som exempelvis 1,76 för 1 meter och 76 centimeter).
Koden beräknar sedan BMI-värdet enligt WHO-formulan och skriver ut det till användaren.
Utifrån BMI-värdet skriver programmen personens viktklass enlgit BMI tabellen, såsom undervikt, sund och normal vikt, övervikt, kraftig övervikt eller extrem övervikt.
Sedan börjar programmet med BMR kod. Den börjar med att skriva ut en BMR-räknarens rubrik och en kort beskrivning av att BMR räknas enligt Mifflin-St Jeor-ekvationen.
Användaren uppmanas att ange sin vikt (i kg), längd (i cm), ålder och kön (M/F). Därefter beräknar programmet BMR-värdet antingen för man eller kvinna beroende på det inmatade könet enligt Mifflin-St Jeor-ekvationen med hjälp av if satser och skriver ut det. Om de inmatade värdena är utanför de giltiga intervallen för vikt, längd eller ålder eller om könet inte är M/F, m/f, skrivs ett felmeddelande ut ”Ogiltig val!”.  
Programmet skriver ut både BMR och BMI-värdena och avslutas med en avslutningshälsning och väntar på att användaren trycker på en tangent för att avsluta programmet.
 

Programmet är skapat av:
Samir Ahmad
Student – programmering 1 
