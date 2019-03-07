import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";

import { environment } from "src/environments/environment";
import { Observable } from "rxjs";
import { map } from "rxjs/operators";
import { Destaque } from "../models/destque.model";

@Injectable({
  providedIn: "root"
})
export class HomeService {
  private urlHome = `${environment.url}/destaques`;

  constructor(private http: HttpClient) {}

  getDestaques(): Observable<Destaque> {
    return this.http.get<Destaque>(this.urlHome).pipe(map(resp => resp));
  }
}
