import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: 'home',
    title: 'Menu - Pizza App',
    loadComponent: () => import('./features/menu/home/home').then((m) => m.Home),
  },
];
