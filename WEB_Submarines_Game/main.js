// Nof Levi Project
//Retrieve stored high scores
function GetStoredHighScores() {
  var highScores = [];
  var storedHighScores = localStorage.getItem('highScores');

  if (storedHighScores) {
    highScores = JSON.parse(storedHighScores);
  }
  
  
  return highScores;
}

//changing the leaderboard function
function Changeleaderboard(person, turns) {
  var highScores = GetStoredHighScores();

  //Add new score to the leaderboard
  highScores.push({
    name: person,
    turns: turns
  });

  //TODO: Implement ordering logic 
  var i,j;
  var tempname,tempturns;
  var max = highScores.length; //giving the length of the array [WORK]
  
  for(i=0;i<max;i++)//inesrtion sort algorithem
  {
	  for(j=0;j<max;j++)
	  {
		if(Number(highScores[i].turns) < Number(highScores[j].turns))//ask beelzebooobies [problem with the int var]
		{
		  
		  tempturns = highScores[i].turns; // putting the information on temp var
		  tempname = highScores[i].name;
		  
		  highScores[i].name = highScores[j].name; // replacing i and j;
		  highScores[i].turns = highScores[j].turns;
		  
		  highScores[j].name = tempname;
		  highScores[j].turns = tempturns;
		}
	  }
  }

  //Save the new score
  localStorage.setItem('highScores', JSON.stringify(highScores));
}

//printing the leaderboard + reloading the game
function Showleaderboard() {
  document.getElementById('div1').classList.toggle ('hide');	
  var highScores = GetStoredHighScores();
  var i;
  var text2 = "<button id=" + "reload" + ">Reload The Game</button>";

  var text =text2 + "<table border =10 class =\"whitebackground\" >"  ;
  text += "<tr>";
  text += "<td>Spot</td>";
  text += "<td>Name</td>";
  text += "<td>Times Missing</td>";
  text += "</tr>";

  for (i = 1; i <= 5; i++) {
    text += "<tr>";
    text += "<td>" + i + "</td>";
    if (highScores[i-1]) {
      text += "<td>" + highScores[i-1].name + "</td>";
      text += "<td>" + highScores[i-1].turns + "</td>";
    } else {
      text += "<td>Empty</td>";
      text += "<td></td>";
    }
    text += "</tr>";
  }
  text += "</table>"
	document.getElementById('leaderboard').innerHTML = '';	
	document.getElementById('leaderboard').innerHTML += text;
  //leaderboard image
  document.body.style.backgroundImage = "url('lbpic.jpg')";

  document.getElementById("reload").onclick = function() {
    document.location.reload(true)
  };

}




// MAIN //
var i, j, x, y; 
var Table = [];
var spot = [];
//localStorage.clear('highScores'); //deleting the info if needed

for (var i = 0; i < 15; i++) // Making 15x15 table for the game
{
  Table[i] = [];
  for (var j = 0; j < 15; j++) {
    Table[i][j] = 0;
  }
}


// horizontal = 0 vertical = 1 
// x=j and y = i
var verhor, max, flag;
for (i = 0; i < 3; i++) {
  flag = 0;
  verhor = Math.floor(Math.random() * 2)
  if (i == 0) // big ship position
  {
    max = 4;
  } else {
    max = 3;
  }
  if (verhor) {
    while (flag == 0) {
      x = Math.floor(Math.random() * 15);
      y = Math.floor(Math.random() * (15 - max));
      if (Table[y][x] == 0 && Table[y + 1][x] == 0 && Table[y + 2][x] == 0 && Table[y + 3][x] == 0) {
        flag = 1;
      }
    }

    for (j = 0; j < max; j++) {
      Table[y + j][x] = 1;
    }
  } else {
    while (flag == 0) {
      x = Math.floor(Math.random() * (15 - max));
      y = Math.floor(Math.random() * 15);
      if (Table[y][x] == 0 && Table[y][x + 1] == 0 && Table[y][x + 2] == 0 && Table[y][x + 3] == 0) {
        flag = 1;
      }
    }

    for (j = 0; j < max; j++) {
      Table[y][x + j] = 1;
    }
  }
}

// table
var turns = 0,
  match = 0,
  temp = 0;
var table = document.createElement("table");
table.setAttribute("id", "board");
for (i = 0; i < 15; i++) {
  var row = document.createElement("tr");
  for (j = 0; j < 15; j++) {
    var td = document.createElement("td");
    td.setAttribute("id", i + "_" + j);
    row.appendChild(td);
    //td.textContent = Table[i][j]; // remove when done EXPOSING SPOTS
  }
  table.appendChild(row);
}

document.getElementById("div1").appendChild(table);

$(document).ready(function() {

  $("td:not(.checked-miss):not(checked-hit)").on("click", function() {

    var i, j;
    var id = this.getAttribute("id").split("_");
    i = id[0];
    j = id[1]

    if (Table[i][j] === 1) {
      $(this).toggleClass("checked-hit");
      match++;
      Table[i][j] = 2;
      if (match == 10) {
        var person = prompt("YOU WONNNNNNNNNNN!!! .Please enter your name:", "Enter Your Name here: ");
        Changeleaderboard(person, turns);
        Showleaderboard();
      }

    } else {
      $(this).toggleClass("checked-miss");
      if (Table[i][j] == 0) {
        turns++;
		document.getElementById("counter").innerHTML = turns;
      }
    }
  });
});