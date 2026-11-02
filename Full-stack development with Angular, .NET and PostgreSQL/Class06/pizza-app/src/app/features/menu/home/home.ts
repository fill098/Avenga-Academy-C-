import { Component, inject } from '@angular/core';
import { MENU, MenuPizza } from '../menu-data';
import { NgOptimizedImage } from '@angular/common';
import { PizzaCard } from '../pizza-card/pizza-card';
import { MatButtonModule } from '@angular/material/button';
import { Router, RouterLink } from '@angular/router';

@Component({
  imports: [NgOptimizedImage, PizzaCard, MatButtonModule, RouterLink],
  selector: 'app-home',
  styleUrl: './home.scss',
  templateUrl: './home.html',
})
export class Home {
  protected readonly menu = MENU;
  protected readonly router = inject(Router);

  protected navigateToPizzaMaker(selectedPizza: MenuPizza): void {
    // /pizza-maker?pizza=<selectedPizza.id>
    this.router.navigate(['/pizza-maker'], { state: { pizza: selectedPizza } });
  }
}
// export class Home {
//   protected readonly shopName = 'Pizza App';
//   protected readonly toppings = ['Tomato sauce', 'Mozzarella', 'Basil'];
//   protected readonly pizzaCount = signal(0);
//   protected readonly seconds = signal(0);

//   protected readonly total = computed(() => this.pizzaCount() * 5);

//   constructor() {
//     setInterval(() => {
//       this.seconds.update((count) => count + 1);
//     }, 1000);
//   }

//   protected addPizza(): void {
//     this.pizzaCount.update((count) => count + 1);
//   }

//   protected reset(): void {
//     this.pizzaCount.set(0);
//   }
// }
