import { NgOptimizedImage } from '@angular/common';
import { Component, input, output } from '@angular/core';
import { MatButton } from '@angular/material/button';
import {
  MatCard,
  MatCardHeader,
  MatCardContent,
  MatCardTitle,
  MatCardActions,
} from '@angular/material/card';
import { MatChipSet, MatChip } from '@angular/material/chips';
import { MenuPizza } from '../menu-data';

@Component({
  imports: [
    MatCard,
    MatCardHeader,
    MatCardTitle,
    MatCardContent,
    MatChipSet,
    MatChip,
    NgOptimizedImage,
    MatCardActions,
    MatButton,
  ],
  selector: 'app-pizza-card',
  styleUrl: './pizza-card.scss',
  templateUrl: './pizza-card.html',
})
export class PizzaCard {
  readonly pizza = input.required<MenuPizza>();
  // readonly choose = output<MenuPizza>();
}
