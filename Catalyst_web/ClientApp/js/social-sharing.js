function shareToSocial(platform, url, title) {
  let shareUrl;

  switch (platform) {
    case 'facebook':
      shareUrl = `https://www.facebook.com/sharer/sharer.php?u=${encodeURIComponent(url)}&t=${encodeURIComponent(title)}`;
      break;
    case 'twitter':
      shareUrl = `https://twitter.com/intent/tweet?url=${encodeURIComponent(url)}&text=${encodeURIComponent(title)}`;
      break;
    case 'linkedin':
      shareUrl = `https://www.linkedin.com/shareArticle?mini=true&url=${encodeURIComponent(url)}&title=${encodeURIComponent(title)}`;
      break;
    default:
      console.warn(`Unsupported platform: ${platform}`);
      return;
  }

  // Open sharing window with appropriate dimensions
  window.open(shareUrl, 'sharer', 'width=600,height=400');
}
