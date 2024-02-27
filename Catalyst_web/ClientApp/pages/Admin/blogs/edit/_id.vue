<template>
  <div>
    <form @submit.prevent="submitForm" :action="`/api/Blogs/Edit/${blogId}`">
      <div class="form-group container">
        <div class="row">
          <div class="col">
            <label for="titleArm">Title in Armenian</label>
            <input v-model="createData.titleArm" type="text" placeholder="Title in Armenian" name="titleArm">
          </div>

          <div class="col">
            <label for="titleEng">Title in English</label>
            <input v-model="createData.titleEng" type="text" placeholder="Title in English" name="titleEng">
          </div>
        </div>

        <div class="row">
          <div class="col">
            <label for="authorArm">Author in Armenian</label>
            <input v-model="createData.authorArm" type="text" placeholder="Author in Armenian" name="authorArm">
          </div>

          <div class="col">
            <label for="authorEng">Author in English</label>
            <input v-model="createData.authorEng" type="text" placeholder="Author in English" name="authorEng">
          </div>
        </div>

        <div class="row">
          <div class="col">
            <label for="tag">Tags</label>
            <input v-model="createData.tag" type="text" placeholder="tags" name="tag">
          </div>
        </div>

        <div class="row">
          <div class="col">
            <label for="descriptionArm">Description in Armenian</label>
            <textarea rows="4" cols="50" v-model="createData.descriptionArm" type="text" placeholder="Description in Armenian" name="descriptionArm"> </textarea>
          </div>

          <div class="col">
            <label for="descriptionEng">Description in English</label>
            <textarea rows="4" cols="50" v-model="createData.descriptionEng" type="text" placeholder="Description in English" name="descriptionEng"> </textarea>
          </div>
        </div>
        <button type="submit" class="thm-btn become-teacher__form-btn">Submit</button>
      </div>
    </form>
  </div>
</template>

<script>
  import https from 'https';

  export default {
    name: 'EditBlog',
    data() {
      return {
        blogId: null,
        createData: { titleArm: '', titleEng: '', descriptionArm: '', descriptionEng: '', authorArm: '', authorEng: '', tag: '' },
      };
    },
    async created() {
      // Optional: Set up HTTPS agent for self-signed certificates (if needed)
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }

      // Check if a course ID is provided in the route parameters
      if (this.$route.params.id) {
        this.blogId = this.$route.params.id;
        await this.fetchBlogDetails();
      }
    },
    methods: {
      async fetchBlogDetails() {
        try {
          const response = await this.$axios.get(`/api/BlogDetails/${this.blogId}`);
          this.createData = { ...response.data };
        } catch (error) {
          console.error('Error fetching course details:', error);
        }
      },
      async submitForm() {
        try {
          const response = await this.$axios.put(`/api/Blog/Edit/${this.blogId}`, this.createData);
          console.log("response", response);
          if (response) {
            this.$toasted.success('Edit successful!');
            // Redirect after a successful edit
            window.location = "/admin/blogs/list";
          }
        } catch (error) {
          // Handle error and display message
          this.$toasted.error('An error occurred. Please try again.');
        }
      },
    },
  };
</script>

<style scoped>
  .form-group {
    margin-bottom: 20px;
  }

  .row {
    display: flex;
    justify-content: space-between;
    margin-bottom: 10px;
  }

  .col {
    flex: 0 0 48%; /* Adjust the width as needed */
  }

  label {
    display: block;
    margin-bottom: 5px;
    font-weight: bold;
  }

  input,
  textarea,
  select {
    width: 100%;
    padding: 8px;
    border: 1px solid #ccc;
    border-radius: 4px;
    box-sizing: border-box;
    margin-top: 5px;
  }
</style>
