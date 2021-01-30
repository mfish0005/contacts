import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class NullHelperService {

  constructor() { }

  isNullOrUndefined(item: string | number | object): boolean {
      return item === undefined || item === null;
  }

  arrayIsNullOrEmpty(item: string[] | number[] | object[]): boolean {
      return item === undefined || item === null || item.length === 0;
  }

  objectIsNullOrEmpty(item: object): boolean {
    return item === undefined || item === null || Object.keys(item).length === 0;
  }
}
