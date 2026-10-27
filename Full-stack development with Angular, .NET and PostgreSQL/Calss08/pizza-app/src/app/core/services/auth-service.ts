import { HttpClient } from '@angular/common/http';
import { inject, Service } from '@angular/core';
import { environment } from '../../../environments/environment';

@Service()
export class AuthService {
  private readonly http = inject(HttpClient);
  private readonly controller = `auth`;
 
  private readonly url = `${environment.apiUrl}/${this.controller}`;
}
