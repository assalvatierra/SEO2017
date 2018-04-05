<?php
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the
 * installation. You don't have to use the web site, you can
 * copy this file to "wp-config.php" and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * MySQL settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://codex.wordpress.org/Editing_wp-config.php
 *
 * @package WordPress
 */

// ** MySQL settings - You can get this info from your web host ** //
/** The name of the database for WordPress */
define('DB_NAME', 'wordpress');

/** MySQL database username */
define('DB_USER', 'root');

/** MySQL database password */
define('DB_PASSWORD', '12345');

/** MySQL hostname */
define('DB_HOST', 'localhost');

/** Database Charset to use in creating database tables. */
define('DB_CHARSET', 'utf8mb4');

/** The Database Collate type. Don't change this if in doubt. */
define('DB_COLLATE', '');

/**#@+
 * Authentication Unique Keys and Salts.
 *
 * Change these to different unique phrases!
 * You can generate these using the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}
 * You can change these at any point in time to invalidate all existing cookies. This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define('AUTH_KEY',         's )INh.jq1=-7-a^r4Ta&Vz:rOS#jwet_hi?9kcr1z24-:8J]Wqn`9i[l`e*%k|Y');
define('SECURE_AUTH_KEY',  '})H/MUFP_aAa@.mhx&@MiMJJIpoZD-Ylb;ncA(K;8jX$yz3%$bQG.>)cRgRURzID');
define('LOGGED_IN_KEY',    'lOa,,xYSS)Jp3A7?jAz-~^gN/ULcWYAj7o9$dem6?7Au} F{Bq|T@0W,~ucYkx0i');
define('NONCE_KEY',        'v-K1E(0laUCZUjZNs$dc1<OXDmDn;k:JGkoB&nH0,L0VQ3VkxX(:aZLgpk)v*hGt');
define('AUTH_SALT',        'w(F)I<=Rs7%Wo[/S;T>M81A6j*&k!VVU2exNX$J-#~s2)xY3bEOR*I=75<2W-.E@');
define('SECURE_AUTH_SALT', 'dE-5~fm0cp{yVQw ^WOMSqSjmzB$ 7~w~_LAwP?vTZm~su7fr!K93P1-=4T7E=4,');
define('LOGGED_IN_SALT',   '}XDze) }JgL+cV)jUlI5sF:=hr)x[(k,/r-D})ZNoLhZ+)TV}OEYTLyPb$cWH#@}');
define('NONCE_SALT',       ':psVkU]?r&9;+KNWdkV5c^zt.AHt%q)gjA:T`b%qj-i`:lR%j>nqi:7+:;ukj*y4');

/**#@-*/

/**
 * WordPress Database Table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 */
$table_prefix  = 'wp_';

/**
 * For developers: WordPress debugging mode.
 *
 * Change this to true to enable the display of notices during development.
 * It is strongly recommended that plugin and theme developers use WP_DEBUG
 * in their development environments.
 *
 * For information on other constants that can be used for debugging,
 * visit the Codex.
 *
 * @link https://codex.wordpress.org/Debugging_in_WordPress
 */
define('WP_DEBUG', false);
define('WP_ALLOW_MULTISITE', true);
/* That's all, stop editing! Happy blogging. */

/** Absolute path to the WordPress directory. */
if ( !defined('ABSPATH') )
	define('ABSPATH', dirname(__FILE__) . '/');

/** Sets up WordPress vars and included files. */
require_once(ABSPATH . 'wp-settings.php');
