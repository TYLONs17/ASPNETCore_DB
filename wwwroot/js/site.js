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



//

//document.addEventListener('DOMContentLoaded', function () {
//    // Get the carousel element
//    var carousel = document.getElementById('carouselExampleControls')

//    // Get the carousel items
//    var carouselItems = carousel.querySelectorAll('.carousel-item')

//    // Set the initial active item index
//    var activeIndex = 0

//    // Function to show the next slide
//    function showNextSlide() {
//        // Hide the current active item
//        carouselItems[activeIndex].classList.remove('active')

//        // Increment the active index or loop back to the start if at the end
//        activeIndex = (activeIndex + 1) % carouselItems.length

//        // Show the next item
//        carouselItems[activeIndex].classList.add('active')
//    }

//    // Function to show the previous slide
//    function showPrevSlide() {
//        // Hide the current active item
//        carouselItems[activeIndex].classList.remove('active')

//        // Decrement the active index or loop back to the end if at the start
//        activeIndex = (activeIndex - 1 + carouselItems.length) % carouselItems.length

//        // Show the previous item
//        carouselItems[activeIndex].classList.add('active')
//    }

//    // Add event listeners to the next and previous controls
//    var nextControl = carousel.querySelector('.carousel-control-next')
//    var prevControl = carousel.querySelector('.carousel-control-prev')

//    nextControl.addEventListener('click', function (event) {
//        event.preventDefault()
//        showNextSlide()
//    })

//    prevControl.addEventListener('click', function (event) {
//        event.preventDefault()
//        showPrevSlide()
//    })
//})



//document.addEventListener('DOMContentLoaded', function () {
//    var carousel = document.getElementById('carouselExampleControls')
//    var pauseButton = document.getElementById('pausePlayButton')

//    // Add event listener to detect when the carousel is paused
//    carousel.addEventListener('slid.bs.carousel', function (event) {
//        // Check if the carousel is paused
//        if (event.detail && event.detail.paused) {
//            // Change the button icon to play
//            pauseButton.innerHTML = '<i class="fas fa-play"></i>'
//        }
//        //else {
//        //    // Change the button icon back to pause
//        //    pauseButton.innerHTML = '<i class="fas fa-pause"></i>'
//        //}
//    })
//})



//