import { Injectable, inject } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';

@Injectable({
  providedIn: 'root'
})
export class SnackbarService {
  private snack = inject(MatSnackBar);

  error(message: string) {
    this.snack.open(message, 'Close', {
      duration: 5000,
      panelClass: ['snack-error']
    })
  }

  success(message: string) {
    this.snack.open(message, 'Close', {
      duration: 5000,
      panelClass: ['snack-success']
    })
  }
}
