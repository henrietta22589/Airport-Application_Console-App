function name() {
    console.log("Henrietta's Airways");
}
/*name();*/
function ContactNumbers() {
    console.log("2541073298\n6985794115");
}
/*ContactNumbers();*/
function Email() {
    console.log("Contact by email\nhenrietta22589@gmail.com");
}
/*Email();*/
function date(d) {
    console.log("The only accepted values,is the positive values");
    if (d < 0 && d > 31) {
        console.log("The value you have given to us\isn not permitted");
        return "Error -1";
    }
    else {
        console.log("The day you chose is:\n" + d);
        return d;
    }
}/*date(15);*/
function month(m) {
    console.log("The only accepted values,is the positive values");
    if (m > 12 && m <= 0) {
        console.log("The value you have given to us is not allowed");
        return "Error -1";
    }
    else {
        console.log("The month you chose is:\n" + m);
        return m;
    }
}
/*month();*/
function year(y) {
    console.log("The only accepted years is: 2021 and 2022");
    if (y > 2022 && y < 0) {
        console.log("The year you have given to us, is not right.\nTry again.");
        return "Error -1";
    }
    else {
        console.log("The year you have chose is:\n" + y);
        return y;
    }
} /*year();*/
function credit(pay, card) {
    if (card < pay) {
        console.log("The amount of money is not enough for this transaction\n");
        return "Wrong Values. Money in the card is less than payable amount";
    }
    else {
        console.log("The transaction was complete\the cost of the ticket");
        console.log("is charged in your card\nyou will be informed by a text message");
        let charge = (card - pay);
        console.log("The amount f money in your card is:\charge");
        return ("Τhe charge is: " + charge + ".The amount of money in your card is:" + card + "and the amount of money you have to pay is:" + pay);
    }
}
/*credit();*/
function cEmail(em) {
    console.log("You have to give to us your email");
    let check = (email.search("@"));
    if (check == -1) {
        console.log("The email you have given to us is not right\n please try again");
        return "The email is not right";
    }
    else {
        console.log("Your email is:" + em);
        return em;
    }
}
/*cEmail();*/
function depart(airdepar) {
    let airports = ["ATHENS", "ALEXANDROUPOLI", "HERACLEIO", "CORFU", "KEFALONIA", "CHIOS",
        "CHANIA", "KARPATHOS", "IOANNINA", "KAVALA", "RODES", "SITIA", "SKIATHOS", "NAXOS", "MYTILINI",
        "KASTELORIZO", "KALAMATA", "VIENNA", "ROME", "ZURICH", "MOSCHA", "BRATISLAVA", "BUDAPEST", "PARIS"];
    console.log("The airports,of which you can depart is \n" + airports);
    let i = airdepar;
    let check = airports.includes(i);
    if (check == false) {
        console.log("Please try again.\nThe airport you are typing is not, in our list");
        return ("You have to pick one airport from the list which is give to you");
    }
    else {
        console.log("Correct! You have chosen the airport " + airdepar);
        return airdepar;
    }
} /*let choise = prompt("Give me the name, of which you want tou depart");*/
//depart(choise);
function depart_1(airdepar_1) {
    let airports = ["athens", "alexandroupoli", "heracleio", "corfu", "kefalonia", "chios",
        "chania", "karpathos", "ioannina", "kavala", "rodes", "sitia", "skiathos", "naxos", "mutilini",
        "kastelorizo", "kalamata", "vienna", "rome", "zurich", "moscha", "bratislava", "budapest", "paris"];
    let i = airdepar_1;
    let check = airports.includes(i);
    if (check == false) {
        console.log("Please try again.\nThe airport you are typing is not, in our list");
        return ("You have to pick one airport from the list which is give to you");
    }
    else {
        console.log("Correct! You have chosen the airport " + airdepar_1);
        return airdepar_1;
    }
}
//let a = prompt("Give me an airport");
//depart_1(a);
function depart_2(airdepar_2) {
    let airports = ["Αθήνα", "Αλεξανδρούπολη", "Ηράκλειο", "Κέρκυρα", "Κεφαλονία", "Χίος",
        "Χανία", "Κάρπαθος", "Ιωάννινα", "Καβάλα", "Ρόδος", "Σήτεια", "Σκίαθος", "Νάξος", "Μυτιλήνη",
        "Κάστελόριζο", "Καλαμάτα", "Βιέννη", "Ρώμη", "Ζυρίχη", "Μόσχα", "Μπρατισλάβα", "Βουδαπέστη", "Παρίσι"];
    console.log("Μπορείτε να επιλέξετε ένα απο τα αεροδρόμια της παραπάνω λίστας.\n" + airports);
    console.log("ΠΡΟΣΟΧΗ!!Τα ονόματα των αεροδρομίων, πρέπει να γράφονται με το πρώτο γράμμα κεφαλαίο.");
    console.log("Όπως επίσης, θα πρέπει να υπάρχουνε τα σημεία στίξης, τα οποία να είναι και σωστα");
    console.log("Στην περίπτωση κάποιου συντακτίκου\nλάθους,θα βλέπετε το μήνυμα:Δεν βρεθηκε το αεροδρόμιο");
    let i = airdepar_2;
    let check = airports.includes(i);
    if (check == false) {
        console.log("Προσπαθήστε ξανα. Δεν βρέθηκε το αεροδρόμιο.");
        return ("Προσοχή στον τρόπο σύνταξης.");
    }
    else {
        console.log("Σώστα, το αεροδρόμιο που επιλέξατε βρίσκεται στην λίστα και είναι\n " + airdepar_2);
        return airdepar_2;
    }
} /*let b = prompt("Δώσε μου, το όνομα του αεροδρομίου.");*/
//depart_2(b);
function hours_prices(j) {
    let flights = ["10:00", "14:00", "22:00"];
    console.log("The time of departure is\n" + flights);
    console.log("Choose one of the times,which was given to you");
    let check = flights.includes(j);
    if (check == false) {
        console.log("The time you have chosen doesn't exist\nTry again.");
        return ("The time you chose is not avalaible");
    }
    else {
        console.log("The time you have chosen,is included the list\n " + j);
    }
    let select = j;
    let pay;
    if (select == flights[0]) {
        pay = 65;
        console.log("The total cost of your ticket is\n" + pay);
        console.log("In this price is included the taxes of the airport");
        console.log("as well as, one suitcase with a total weight 20kg");
        return pay;
    }
    else if (select == flights[1]) {
        pay = 120;
        console.log("The total cost of your ticket is\n" + pay);
        console.log("In this price is included the taxes of the airport");
        console.log("as well as, one suitcase with a total weight 20kg");
        return pay;
    }
    else {
        pay = 210;
        console.log("The total cost of your ticket is\n" + pay);
        console.log("In this price is included the taxes of the airport");
        console.log("as well as, one suitcase with a total weight 20kg");
        return pay;
    } /*let time = prompt("Give me time");*/
} /*hour_prices(time);*/
function seats(s) {
    console.log("Choose one seat");
    let seats = ["A1", "A2", "A3", "A4", "A5", "A6", "B1", "B2", "B3",
        "B4", "B5", "B6", "G1", "G2", "G3", "G4", "G5", "G6", "D1",
        "D1", "D3", "D4", "D5", "D6", "E1", "E2", "E3"];
    console.log("Choose one of the seat options, which is given to you" + seats);
    let check = seats.includes(s);
    if (check == false) {
        console.log("The seat you are trying to choose is not avaluable");
        console.log("Please try again,by choosing only one seat from the list");
        return "Please try again. the seat is not avaluable";
    }
    else {
        console.log("You have chosen one of the seat list\n" + s);
    }
    for (i = 0; i < seats.length; i++) {
        if (seats[i] == NaN) {
            console.log("This seat has been taken\please choose an another one");
            return "This seat has been taken";
        }
        else {
            console.log("The seat is avaluable");
            return "This seat is avaluable.Enjoy your flight";
        }
    }
} /*let d = prompt("choose your seat");*/
//seats(d);
function depart_0(airdepar_0) {
    let airports = ["ATHENS", "ALEXANDROUPOLI", "HERACLEIO", "CORFU", "KEFALONIA", "CHIOS",
        "CHANIA", "KARPATHOS", "IOANNINA", "KAVALA", "RODES", "SITIA", "SKIATHOS", "NAXOS", "MYTILINI",
        "KASTELORIZO", "KALAMATA", "VIENNA", "ROME", "ZURICH", "MOSCHA", "BRATISLAVA", "BUDAPEST", "PARIS"];
    console.log("The airports,of which you can depart is \n" + airports);
    let i = airdepar_0;
    let check = airports.includes(i);
    if (check == false) {
        console.log("Please try again.\nThe airport you are typing is not, in our list");
        return ("You have to pick one airport from the list which is give to you");
    }
    else {
        console.log("Correct! You have chosen the airport " + airdepar_0);
        return airdepar_0;
    }
} /*let choise_1 = prompt("Give me the name, of which you want tou depart");*/
//depart(choise_1);
function depart_00(airdepar_00) {
    let airports = ["athens", "alexandroupoli", "heracleio", "corfu", "kefalonia", "chios",
        "chania", "karpathos", "ioannina", "kavala", "rodes", "sitia", "skiathos", "naxos", "mutilini",
        "kastelorizo", "kalamata", "vienna", "rome", "zurich", "moscha", "bratislava", "budapest", "paris"];
    let i = airdepar_00;
    let check = airports.includes(i);
    if (check == false) {
        console.log("Please try again.\nThe airport you are typing is not, in our list");
        return ("You have to pick one airport from the list which is give to you");
    }
    else {
        console.log("Correct! You have chosen the airport " + airdepar_00);
        return airdepar_00;
    }
}/*let choise_2 = prompt("Give me the name, of which you want tou depart");*/
//depart(choise_2);
function depart_000(airdepar_000) {
    let airports = ["Αθήνα", "Αλεξανδρούπολη", "Ηράκλειο", "Κέρκυρα", "Κεφαλονία", "Χίος",
        "Χανία", "Κάρπαθος", "Ιωάννινα", "Καβάλα", "Ρόδος", "Σήτεια", "Σκίαθος", "Νάξος", "Μυτιλήνη",
        "Κάστελόριζο", "Καλαμάτα", "Βιέννη", "Ρώμη", "Ζυρίχη", "Μόσχα", "Μπρατισλάβα", "Βουδαπέστη", "Παρίσι"];
    console.log("Μπορείτε να επιλέξετε ένα απο τα αεροδρόμια της παραπάνω λίστας.\n" + airports);
    console.log("ΠΡΟΣΟΧΗ!!Τα ονόματα των αεροδρομίων, πρέπει να γράφονται με το πρώτο γράμμα κεφαλαίο.");
    console.log("Όπως επίσης, θα πρέπει να υπάρχουνε τα σημεία στίξης, τα οποία να είναι και σωστα");
    console.log("Στην περίπτωση κάποιου συντακτίκου\nλάθους,θα βλέπετε το μήνυμα:Δεν βρεθηκε το αεροδρόμιο");
    let i = airdepar_000;
    let check = airports.includes(i);
    if (check == false) {
        console.log("Προσπαθήστε ξανα. Δεν βρέθηκε το αεροδρόμιο.");
        return ("Προσοχή στον τρόπο σύνταξης.");
    }
    else {
        console.log("Σώστα, το αεροδρόμιο που επιλέξατε βρίσκεται στην λίστα και είναι\n " + airdepar_000);
        return airdepar_000;
    }
}/*let choise_3 = prompt("Give me the name, of which you want tou depart");*/
//depart(choise_3);
//ΑΡΧΗ ΚΥΡΙΟΥ ΠΡΟΓΡΑΜΜΑΤΟΣ - ΑΡΧΗ ΚΥΡΙΟΥ ΠΡΟΓΡΑΜΜΑΤΟΣ-
//-ΑΡΧΗ ΚΥΡΙΟΥ ΠΡΟΓΡΑΜΜΑΤΟΣ - ΑΡΧΗ ΚΥΡΙΟΥ ΠΡΟΓΡΑΜΜΑΤΟΣ -
function program_Begin() {
    console.log("Greetings Dear Passengers.");
    console.log("We appreciate your choise in\nHenrietta's Airways.");
    console.log("Our Journey begins, with your Departure and ends with your Arrival in your destination.");
    console.log("For any further information, you can contact with us.");
    console.log("The necessary contact infromation is provided to you just below.");
    console.log("Contact info-By your side 24hours/day.The time frame");
    console.log("in responding in your email is:(30-45)minutes.");
    name();
    ContactNumbers();
    Email();
    console.log("Before you start the booking of your flight.");
    console.log("i have to inform you that, if you have the same");
    console.log("airport name, for the departure airport and for the arrival airport.");
    console.log("You won't be able to BOOK A FLIGHT!!!!");
    let choice_1;
    let choice_2;
    do {
        let airdepar = prompt("Choose the airport you want to depart");
        choice_1 = depart(airdepar);
        let airdepar_0 = prompt("Choose the airport you want to arrive");
        choice_2 = depart_0(airdepar_0);
    } while (choice_1 == choice_2);
    let date_1 = prompt("Give me the date you want to travel");
    let choice_date = date(date_1);
    let month_1 = prompt("Give me the month you want to travel")
    let choice_month = month(month_1);
    let year_1 = prompt("Give me the year you want to travel")
    let choice_year = year(year_1);
    let flight_1 = prompt("Choose one of the available flights.");
    let choice_flights = hours_prices(flight_1);
    let seats_1 = prompt("Choose the seat, in which you want to travel");
    let choice_seats = seats(seats_1);
    let pass_name = prompt("Give me your name");
    console.log("the name you have given to me is:" + pass_name);
    let last_name = prompt("Give me your last name");
    console.log("the last name you have given to me is:" + last_name);
    let iD_Card = prompt("Give me the number of your ID card");
    console.log("the number of you ID card is:" + iD_Card);
    let eMail_1 = prompt("Give me you Email");
    let choice_Email = cEmail(eMail_1);
    console.log("In This part you have to give me the number of your credit");
    console.log("card so you could procced to buy the ticket");
    console.log("The transaction will be acomplished if you have money in your Credit card");
    let credit_1 = prompt("give me your credit");
    let choice_credit = credit(credit_1);
    console.log("I wish you have a pleasant Journey");
}
program_Begin()