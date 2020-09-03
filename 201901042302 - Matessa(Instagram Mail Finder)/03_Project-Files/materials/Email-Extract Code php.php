<?php
function findEmail() {
var email = "No email address detected";
var a = 0;
var ingroup = 0;
var separator = document.extractor.sep.value;
var groupby = Math.round(document.extractor.groupby.value);

if (separator == "new") separator = "\n";
if (separator == "other") separator = document.extractor.othersep.value;
var rawemail = document.extractor.rawdata.value.match(/([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9._-]+)/gi);
var norepeat = new Array();
if (rawemail) {
	for (var i=0; i<rawemail.length; i++) {
		var repeat = 0;
		
		// Check for repeated emails routine
		for (var j=i+1; j<rawemail.length; j++) {
			if (rawemail[i] == rawemail[j]) {
				repeat++;
			}
		}
		
		// Create new array for non-repeated emails
		if (repeat == 0) {
			norepeat[a] = rawemail[i];
			a++;
		}
	}
	if (document.extractor.sort.checked) norepeat = norepeat.sort(); // Sort the array
	email = "";
	// Join emails together with separator
	for (var k = 0; k < norepeat.length; k++) {
		if (ingroup != 0) email += separator;
		email += norepeat[k];
		ingroup++;
		
		// Group emails if a number is specified in form. Each group will be separate by new line.
		if (groupby) {
		    if (ingroup == groupby) {
		        email += '\n\n';
		        ingroup = 0;
		    }
		}
	}
}
?>