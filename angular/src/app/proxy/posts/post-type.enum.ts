import { mapEnumToOptions } from '@abp/ng.core';

export enum PostType {
  Undefined = 0,
  Tech = 1,
  Life = 2,
  Book = 3,
}

export const postTypeOptions = mapEnumToOptions(PostType);
