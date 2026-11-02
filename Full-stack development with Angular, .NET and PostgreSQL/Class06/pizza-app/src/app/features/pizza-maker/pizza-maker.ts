import { Component, computed, input, signal } from '@angular/core';
import { Ingredient } from '../../shaerd/models/pizza-models';
import { PIZZA_SIZES, PizzaSize } from '../../shaerd/models/pizza-size';
import { calculatePizzaPrice } from './pizza-price';

const DEFAULT_NAME = 'Custom pizza';
@Component({
  imports: [],
  selector: 'app-pizza-maker',
  styleUrl: './pizza-maker.scss',
  templateUrl: './pizza-maker.html',
})
export class PizzaMaker {
  readonly pizza = input<string>();

  protected readonly sizes = PIZZA_SIZES;
  protected readonly name = signal(DEFAULT_NAME);
  protected readonly size = signal<PizzaSize>('Medium');
  protected readonly ingredients = signal<Ingredient[]>([]);

  protected readonly price = computed(() => calculatePizzaPrice(this.size(), this.ingredients()));
}
