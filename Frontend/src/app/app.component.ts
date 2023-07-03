import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'AngBigB';
  // constructor(private router: Router) { }

  // ngOnInit(): void {

  //   window.addEventListener('load', () => {
  //     const image = document.getElementById('animatedImage1');
  //     if (image) {
  //       const imagePosition = image.getBoundingClientRect().top;
  //       const windowHeight = window.innerHeight;
  //       if (imagePosition < windowHeight) {
  //         image.classList.add('animate');
  //       } else {
  //         image.classList.remove('animate');
  //       }
  //     }
  //   })
  // }
  role: string = localStorage.getItem('role') || '';

  

  constructor(private route:Router)
  {

  }

  Register(){
    this.route.navigate(['register']);
  }
  logOutPage() {
    localStorage.removeItem("token");
    localStorage.removeItem("role");
    this.route.navigate(['logIN']).then(() => {
      // Optional: Scroll to the top of the page
      window.scrollTo(0, 0);
      location.reload();

    });
  }
  

  loginpage() {
    location.reload();
  }



  styleNav() {
    this.route.navigate(['comp1']);
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
// }

