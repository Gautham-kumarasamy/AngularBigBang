import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  ngOnInit(): void {

    window.addEventListener('load', () => {
      const image = document.getElementById('animatedImage1');
      if (image) {
        const imagePosition = image.getBoundingClientRect().top;
        const windowHeight = window.innerHeight;
        if (imagePosition < windowHeight) {
          image.classList.add('animate');
        } else {
          image.classList.remove('animate');
        }
      }
    })
  }

  constructor(private router: Router) {}

  styleNav() {
    this.router.navigate(['comp1']);
  }
}

//   hide() {
//     const button = document.getElementById("hideButton");

//     if (button) {
//       button.addEventListener("click", () => {
//         // Get the elements to hide
//         const elementsToHide = document.querySelectorAll(".imgAKKA, .abt, .diff, .mov");

//         // Loop through the elements and hide them
//         elementsToHide.forEach((element: HTMLElement) => {
//           element.style.display = "none";
//         });
//       });
//     }
//   }

