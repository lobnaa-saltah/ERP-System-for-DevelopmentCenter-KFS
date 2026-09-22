function refrClock() {
    var d = new Date();
    var s = d.getSeconds();
    var m = d.getMinutes();
    var h = d.getHours();
    var day = d.getDay();
    var date = d.getDate();
    var month = d.getMonth();
    var year = d.getFullYear();
    var days = new Array("الاحد", "الاثنين", "الثلاثاء", "الاربعاء", "الخميس", "الجمعة", "السبت");
    var months = new Array("يناير", "فبراير", "مارس", "ابريل", "مايو", "يونيو", "يوليو", "اغسطس", "سبتمبر", "اكتوبر", "نوفمبر", "ديسمبر");
    var am_pm;
    if (s < 10) { s = "0" + s }
    if (m < 10) { m = "0" + m }
    if (h > 12) { h -= 12; am_pm = "مساءً" }
    else { am_pm = "صباحاً" }
    if (h < 10) { h = "0" + h }
    document.getElementById("clock").innerHTML = days[day] + " - " + date + months[month] + " " + year + "  /  " + " " + " " + h + ":" + m + ":" + s + " " + am_pm;
    setTimeout("refrClock()", 1000);
}
refrClock();

const myCarouselElement = document.querySelector('#myCarousel')
const carousel = new bootstrap.Carousel(myCarouselElement, {
interval: 1000,
wrap: false
})


var myVar;

//function myFunction() {
//  myVar = setTimeout(showPage, 3000);
//}

//function showPage() {
//  document.getElementById("loader").style.display = "none";
//  document.getElementById("myDiv").style.display = "block";
//}
