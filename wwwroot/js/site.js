// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.




function updateRecipient() { // Called when the form is submitted
    var choice = document.querySelector('input[name="choice"]:checked').value
    var campusEmail = document.getElementById('campusEmail')

    if (choice === 'BFN Campus') {
        campusEmail.value = 'CUTAdminBFN2024@gmail.com'
    } else if (choice === 'WLK Campus') {
        campusEmail.value = 'CUTAdminWLK2024@gmail.com'
    }

    return true // Allows the form submission to proceed
}

