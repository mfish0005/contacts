# Color Helpers
 Classes that help with colors live in `src/helpers/colors.scss`

## .has-text-{color-name}
This class allows setting text color.  **All supported colors listed in the tables at the bottom.**

### Usage:
```html
<p class="has-text-primary">This text is green(our primary color)</p>

<h3 class="has-text-warning">This text is orange(our warning color)</h3>

<a class="has-text-link">This link is aqua(our link color)</a>

<p class="has-text-blue">This text is blue</p>

<h1 class="has-text-blue-darkest">This text is our darkest shade of blue</h1>
```
One should avoid using the literal color names where possible.  E.G. Use `class="has-text-primary"` instead of `class="has-text-green"`.

## .has-background-{color-name}
This class allows setting background color.  **All supported colors listed in the tables at the bottom.**

### Usage:
```html
<span class="has-background-primary">This span has our primary background color</span>

<h1 class="has-background-purple">This h1 has a purple background</h1>

<div class="has-background-purple-light">This div has a light purple background color</div>
```
One should avoid using the literal color names where possible.  E.G. If possible use `class="has-background-warning"` instead of `class="has-background-orange"`.

## - Commonly Used -

## primary (green)

### Usage:
```html
<div class="has-background-primary">
This div has our primary background color
</div>

<p class="has-text-primary">
This text is our primary color
<p>
```

## success (green)
### Usage:
```html
<label class="has-text-success">
Success! This success message is our success color!
<label>
```

## warning (orange)
```html
<label class="has-text-warning">
Warning! This message is our warning color!
<label>
```

## danger (red)
```html
<label class="has-text-danger">
Danger! Will Robinson printed this in our danger color!
<label>
```

## Literal Colors
| Color              | Hex     | Color             | Hex     | Color               | Hex     | Color             | Hex     |
|--------------------|---------|-------------------|---------|---------------------|---------|-------------------|---------|
| $green-super-light | #f6feed | $gray-super-light | #f8f7f6 | $orange-super-light | #fff3e0 | $blue-super-light | #e2e9f3 |
| $green-lightest    | #edfcda | $gray-lightest    | #eceff1 | $orange-lightest    | #fff3e0 | $blue-lightest    | #e2e9f3 |
| $green-lighter     | #c2eda4 | $gray-lighter     | #cfd8dc | $orange-lighter     | #ffe0b2 | $blue-lighter     | #6e93cc |
| $green-light       | #8ddb56 | $gray-light       | #b0bec5 | $orange-light       | #ffa726 | $blue-light       | #3462ae |
| $green             | #50a000 | $gray             | #90a4ae | $orange             | #ff9800 | $blue             | #17489e |
| $green-dark        | #438500 | $gray-dark        | #718792 | $orange-dark        | #e96100 | $blue-dark        | #17489e |
| $green-darker      | #356b00 | $gray-darker      | #455a64 | $orange-darker      | #c43e00 | $blue-darker      | #1e3866 |
| $green-darkest     | #285000 | $gray-darkest     | #1c313a | $orange-darkest     | #c43e00 | $blue-darkest     | #1e3866 |

## Literal Colors Continued
| Color             | Hex     | Color               | Hex     | Color            | Hex     | Color               | Hex     |
|-------------------|---------|---------------------|---------|------------------|---------|---------------------|---------|
| $aqua-super-light | #e9f9ff | $yellow-super-light | #fdf6c9 | $red-super-light | #fbe9e7 | $purple-super-light | #f3e5f5 |
| $aqua-lightest    | #b3e5fc | $yellow-lightest    | #fdf6c9 | $red-lightest    | #fbe9e7 | $purple-lightest    | #f3e5f5 |
| $aqua-lighter     | #81d4fa | $yellow-lighter     | #fff490 | $red-lighter     | #ef9a9a | $purple-lighter     | #e1bee7 |
| $aqua-light       | #41b7e3 | $yellow-light       | #fae64e | $red-light       | #d32f2f | $purple-light       | #ce93d8 |
| $aqua             | #0099cc | $yellow             | #f5d80c | $red             | #a91818 | $purple             | #7b1fa2 |
| $aqua-dark        | #00779f | $yellow-dark        | #e0ad09 | $red-dark        | #7f0000 | $purple-dark        | #4a0072 |
| $aqua-darker      | #005572 | $yellow-darker      | #cc8206 | $red-darker      | #4c0000 | $purple-darker      | #33004f |
| $aqua-darkest     | #005572 | $yellow-darkest     | #cc8206 | $red-darkest     | #4c0000 | $purple-darkest     | #33004f |
| $white            | #ffffff |                     |         |                  |         |                     |         |
| $black            | #000000 |                     |         |                  |         |                     |         |

## Derived Colors
| Class   | Color  | Hex     |
|---------|--------|---------|
| primary | green  | #50a000 |
| success | green  | #50a000 |
| warning | orange | #ff9800 |
| danger  | red    | #a91818 |
| info    | blue   | #17489e |
| link    | aqua   | #0099cc |
| link-hover    | aqua-darker | #005572 |
| text    | gray-darker | #455a64 |
